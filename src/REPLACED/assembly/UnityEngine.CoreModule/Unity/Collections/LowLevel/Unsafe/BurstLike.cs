// Decompiled with JetBrains decompiler
// Type: Unity.Collections.LowLevel.Unsafe.BurstLike
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

public static class BurstLike : Il2CppSystem.Object
{
  private static readonly BurstLike.NativeFunctionCall_Int_IntPtr_IntPtrDelegate NativeFunctionCall_Int_IntPtr_IntPtrDelegateField;

  static BurstLike()
  {
    Il2CppClassPointerStore<BurstLike>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", nameof (BurstLike));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstLike>.NativeClassPtr);
    BurstLike.NativeFunctionCall_Int_IntPtr_IntPtrDelegateField = IL2CPP.ResolveICall<BurstLike.NativeFunctionCall_Int_IntPtr_IntPtrDelegate>("Unity.Collections.LowLevel.Unsafe.BurstLike::NativeFunctionCall_Int_IntPtr_IntPtr");
  }

  public BurstLike(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static int NativeFunctionCall_Int_IntPtr_IntPtr(
    System.IntPtr function,
    System.IntPtr p0,
    System.IntPtr p1,
    out int error)
  {
    return BurstLike.NativeFunctionCall_Int_IntPtr_IntPtrDelegateField(function, p0, p1, (System.IntPtr) ref error);
  }

  public sealed class SharedStatic<T> : Il2CppSystem.ValueType where T : new()
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__buffer;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Data_Public_get_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0;

    static SharedStatic()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstLike>.NativeClassPtr, "SharedStatic`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr);
      BurstLike.SharedStatic<T>.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr, nameof (_buffer));
      BurstLike.SharedStatic<T>.NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr, 100663560 /*0x06000108*/);
      BurstLike.SharedStatic<T>.NativeMethodInfoPtr_get_Data_Public_get_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr, 100663561 /*0x06000109*/);
      BurstLike.SharedStatic<T>.NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr, 100663562 /*0x0600010A*/);
    }

    [CallerCount(65)]
    [CachedScanResults(RefRangeStart = 79672, RefRangeEnd = 79737, XrefRangeStart = 79672, XrefRangeEnd = 79737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SharedStatic(void* buffer)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) buffer
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BurstLike.SharedStatic<T>.NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe ref T Data
    {
      [CallerCount(10), CachedScanResults(RefRangeStart = 414636, RefRangeEnd = 414646, XrefRangeStart = 414635, XrefRangeEnd = 414636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        System.IntPtr data = IL2CPP.il2cpp_runtime_invoke(BurstLike.SharedStatic<T>.NativeMethodInfoPtr_get_Data_Public_get_byref_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
        return (T&) data;
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414646, XrefRangeEnd = 414651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BurstLike.SharedStatic<T> GetOrCreate<TContext>(uint alignment = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &alignment
      };
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BurstLike.SharedStatic<TContext>.MethodInfoStoreGeneric_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0\u00601.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new BurstLike.SharedStatic<T>(pointer);
    }

    public SharedStatic(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public SharedStatic()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr))
    {
    }

    public unsafe void* _buffer
    {
      get
      {
        return (void*) *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BurstLike.SharedStatic<T>.NativeFieldInfoPtr__buffer));
      }
      [param: In] set
      {
        *(void**) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BurstLike.SharedStatic<T>.NativeFieldInfoPtr__buffer)) = value;
      }
    }

    private sealed class MethodInfoStoreGeneric_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0\u00601
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BurstLike.SharedStatic<TContext>.NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0, Il2CppClassPointerStore<BurstLike.SharedStatic<TContext>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContext>.NativeClassPtr))
      }))));
    }
  }

  public static class SharedStatic : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateSharedStaticInternal_Public_Static_ptr_Void_Int64_Int64_UInt32_UInt32_0;

    static SharedStatic()
    {
      Il2CppClassPointerStore<BurstLike.SharedStatic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstLike>.NativeClassPtr, nameof (SharedStatic));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstLike.SharedStatic>.NativeClassPtr);
      BurstLike.SharedStatic.NativeMethodInfoPtr_GetOrCreateSharedStaticInternal_Public_Static_ptr_Void_Int64_Int64_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstLike.SharedStatic>.NativeClassPtr, 100663563 /*0x0600010B*/);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 414654, RefRangeEnd = 414655, XrefRangeStart = 414651, XrefRangeEnd = 414654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void* GetOrCreateSharedStaticInternal(
      long getHashCode64,
      long getSubHashCode64,
      uint sizeOf,
      uint alignment)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &getHashCode64;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getSubHashCode64;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sizeOf;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &alignment;
      System.IntPtr num;
      System.IntPtr sharedStaticInternal = IL2CPP.il2cpp_runtime_invoke(BurstLike.SharedStatic.NativeMethodInfoPtr_GetOrCreateSharedStaticInternal_Public_Static_ptr_Void_Int64_Int64_UInt32_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return (void*) sharedStaticInternal;
    }

    public SharedStatic(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }

  private delegate int NativeFunctionCall_Int_IntPtr_IntPtrDelegate(
    System.IntPtr function,
    System.IntPtr p0,
    System.IntPtr p1,
    [Out] System.IntPtr error);
}
