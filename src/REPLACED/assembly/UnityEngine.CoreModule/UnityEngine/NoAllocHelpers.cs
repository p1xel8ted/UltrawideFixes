// Decompiled with JetBrains decompiler
// Type: UnityEngine.NoAllocHelpers
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public static class NoAllocHelpers : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SafeLength_Public_Static_Int32_Array_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SafeLength_Public_Static_Int32_List_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExtractArrayFromList_Public_Static_Il2CppArrayBase_1_T_List_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetListContents_Public_Static_Void_List_1_T_ReadOnlySpan_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetListSize_Public_Static_Void_List_1_T_Int32_0;

  static NoAllocHelpers()
  {
    Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (NoAllocHelpers));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr);
    NoAllocHelpers.NativeMethodInfoPtr_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100668238);
    NoAllocHelpers.NativeMethodInfoPtr_SafeLength_Public_Static_Int32_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100668239);
    NoAllocHelpers.NativeMethodInfoPtr_SafeLength_Public_Static_Int32_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100668240);
    NoAllocHelpers.NativeMethodInfoPtr_ExtractArrayFromList_Public_Static_Il2CppArrayBase_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100668241);
    NoAllocHelpers.NativeMethodInfoPtr_ResetListContents_Public_Static_Void_List_1_T_ReadOnlySpan_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100668242);
    NoAllocHelpers.NativeMethodInfoPtr_ResetListSize_Public_Static_Void_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100668243);
  }

  [CallerCount(17)]
  [CachedScanResults(RefRangeStart = 452879, RefRangeEnd = 452896, XrefRangeStart = 452876, XrefRangeEnd = 452879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EnsureListElemCount<T>(List<T> list, int count)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.MethodInfoStoreGeneric_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(38)]
  [CachedScanResults(RefRangeStart = 452897, RefRangeEnd = 452935, XrefRangeStart = 452896, XrefRangeEnd = 452897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int SafeLength(Il2CppSystem.Array values)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) values)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.NativeMethodInfoPtr_SafeLength_Public_Static_Int32_Array_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 452936, RefRangeEnd = 452959, XrefRangeStart = 452935, XrefRangeEnd = 452936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int SafeLength<T>(List<T> values)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) values)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.MethodInfoStoreGeneric_SafeLength_Public_Static_Int32_List_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452959, XrefRangeEnd = 452961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppArrayBase<T> ExtractArrayFromList<T>(List<T> list)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.MethodInfoStoreGeneric_ExtractArrayFromList_Public_Static_Il2CppArrayBase_1_T_List_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452961, XrefRangeEnd = 452964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ResetListContents<T>(List<T> list, Il2CppSystem.ReadOnlySpan<T> span)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) span));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.MethodInfoStoreGeneric_ResetListContents_Public_Static_Void_List_1_T_ReadOnlySpan_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452964, XrefRangeEnd = 452971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ResetListSize<T>(List<T> list, int size) where T : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.MethodInfoStoreGeneric_ResetListSize_Public_Static_Void_List_1_T_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public NoAllocHelpers(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static Il2CppArrayBase<T> ExtractArrayFromListT<T>(List<T> list)
  {
    return NoAllocHelpers.ExtractArrayFromList<T>(list);
  }

  public class ListPrivateFieldAccess<T>(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__items;
    private static readonly System.IntPtr NativeFieldInfoPtr__size;
    private static readonly System.IntPtr NativeFieldInfoPtr__version;

    static ListPrivateFieldAccess()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<NoAllocHelpers.ListPrivateFieldAccess<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, "ListPrivateFieldAccess`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoAllocHelpers.ListPrivateFieldAccess<T>>.NativeClassPtr);
      NoAllocHelpers.ListPrivateFieldAccess<T>.NativeFieldInfoPtr__items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoAllocHelpers.ListPrivateFieldAccess<T>>.NativeClassPtr, nameof (_items));
      NoAllocHelpers.ListPrivateFieldAccess<T>.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoAllocHelpers.ListPrivateFieldAccess<T>>.NativeClassPtr, nameof (_size));
      NoAllocHelpers.ListPrivateFieldAccess<T>.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoAllocHelpers.ListPrivateFieldAccess<T>>.NativeClassPtr, nameof (_version));
    }

    public unsafe Il2CppArrayBase<T> _items
    {
      get
      {
        return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoAllocHelpers.ListPrivateFieldAccess<T>.NativeFieldInfoPtr__items)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoAllocHelpers.ListPrivateFieldAccess<T>.NativeFieldInfoPtr__items), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _size
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoAllocHelpers.ListPrivateFieldAccess<T>.NativeFieldInfoPtr__size));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoAllocHelpers.ListPrivateFieldAccess<T>.NativeFieldInfoPtr__size)) = value;
      }
    }

    public unsafe int _version
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoAllocHelpers.ListPrivateFieldAccess<T>.NativeFieldInfoPtr__version));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoAllocHelpers.ListPrivateFieldAccess<T>.NativeFieldInfoPtr__version)) = value;
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NoAllocHelpers.NativeMethodInfoPtr_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0, Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SafeLength_Public_Static_Int32_List_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NoAllocHelpers.NativeMethodInfoPtr_SafeLength_Public_Static_Int32_List_1_T_0, Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_ExtractArrayFromList_Public_Static_Il2CppArrayBase_1_T_List_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NoAllocHelpers.NativeMethodInfoPtr_ExtractArrayFromList_Public_Static_Il2CppArrayBase_1_T_List_1_T_0, Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_ResetListContents_Public_Static_Void_List_1_T_ReadOnlySpan_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NoAllocHelpers.NativeMethodInfoPtr_ResetListContents_Public_Static_Void_List_1_T_ReadOnlySpan_1_T_0, Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_ResetListSize_Public_Static_Void_List_1_T_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NoAllocHelpers.NativeMethodInfoPtr_ResetListSize_Public_Static_Void_List_1_T_Int32_0, Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
