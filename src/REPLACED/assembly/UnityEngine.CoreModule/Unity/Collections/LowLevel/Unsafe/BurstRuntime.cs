// Decompiled with JetBrains decompiler
// Type: Unity.Collections.LowLevel.Unsafe.BurstRuntime
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
namespace Unity.Collections.LowLevel.Unsafe;

public static class BurstRuntime : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HashStringWithFNV1A64_Internal_Static_Int64_String_0;

  static BurstRuntime()
  {
    Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", nameof (BurstRuntime));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr);
    BurstRuntime.NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663564 /*0x0600010C*/);
    BurstRuntime.NativeMethodInfoPtr_HashStringWithFNV1A64_Internal_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663565 /*0x0600010D*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414658, RefRangeEnd = 414659, XrefRangeStart = 414655, XrefRangeEnd = 414658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe long GetHashCode64<T>()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.MethodInfoStoreGeneric_GetHashCode64_Public_Static_Int64_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(long*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414661, RefRangeEnd = 414662, XrefRangeStart = 414659, XrefRangeEnd = 414661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe long HashStringWithFNV1A64(string text)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.NativeMethodInfoPtr_HashStringWithFNV1A64_Internal_Static_Int64_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(long*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public BurstRuntime(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public sealed class HashCode64<T> : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;

    static HashCode64()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, "HashCode64`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr);
      BurstRuntime.HashCode64<T>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr, nameof (Value));
    }

    public HashCode64(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public HashCode64()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr))
    {
    }

    public static unsafe long Value
    {
      get
      {
        long num;
        IL2CPP.il2cpp_field_static_get_value(BurstRuntime.HashCode64<T>.NativeFieldInfoPtr_Value, (void*) &num);
        return num;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BurstRuntime.HashCode64<T>.NativeFieldInfoPtr_Value, (void*) &value);
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_GetHashCode64_Public_Static_Int64_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BurstRuntime.NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_0, Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
