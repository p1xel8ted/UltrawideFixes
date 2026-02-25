// Decompiled with JetBrains decompiler
// Type: UnityEngine.Bindings.Unmarshal
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
public struct Unmarshal
{
  private static readonly System.IntPtr NativeMethodInfoPtr_UnmarshalUnityObject_Public_Static_T_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FromIntPtrUnsafe_Public_Static_GCHandle_IntPtr_0;

  static Unmarshal()
  {
    Il2CppClassPointerStore<Unmarshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Bindings", nameof (Unmarshal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Unmarshal>.NativeClassPtr);
    Unmarshal.NativeMethodInfoPtr_UnmarshalUnityObject_Public_Static_T_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unmarshal>.NativeClassPtr, 100669185);
    Unmarshal.NativeMethodInfoPtr_FromIntPtrUnsafe_Public_Static_GCHandle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unmarshal>.NativeClassPtr, 100669186);
  }

  [CallerCount(184)]
  [CachedScanResults(RefRangeStart = 474626, RefRangeEnd = 474810, XrefRangeStart = 474618, XrefRangeEnd = 474626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T UnmarshalUnityObject<T>(System.IntPtr gcHandlePtr) where T : UnityEngine.Object
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &gcHandlePtr
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Unmarshal.MethodInfoStoreGeneric_UnmarshalUnityObject_Public_Static_T_IntPtr_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474810, XrefRangeEnd = 474811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppSystem.Runtime.InteropServices.GCHandle FromIntPtrUnsafe(
    System.IntPtr gcHandle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &gcHandle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Unmarshal.NativeMethodInfoPtr_FromIntPtrUnsafe_Public_Static_GCHandle_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Il2CppSystem.Runtime.InteropServices.GCHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unmarshal>.NativeClassPtr, (System.IntPtr) ref this));
  }

  private sealed class MethodInfoStoreGeneric_UnmarshalUnityObject_Public_Static_T_IntPtr_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Unmarshal.NativeMethodInfoPtr_UnmarshalUnityObject_Public_Static_T_IntPtr_0, Il2CppClassPointerStore<Unmarshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
