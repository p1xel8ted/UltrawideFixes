// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Utils.ArticyAssetHelper
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity.Utils;

public static class ArticyAssetHelper : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadAsset_Public_Static_ValueTuple_2_T_Object_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadAssetAsync_Public_Static_Task_1_ValueTuple_2_T_Object_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_ValueTuple_2_Object_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFinalFilePath_Private_Static_String_String_Boolean_0;

  static ArticyAssetHelper()
  {
    Il2CppClassPointerStore<ArticyAssetHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Utils", nameof (ArticyAssetHelper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyAssetHelper>.NativeClassPtr);
    ArticyAssetHelper.NativeMethodInfoPtr_LoadAsset_Public_Static_ValueTuple_2_T_Object_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyAssetHelper>.NativeClassPtr, 100664305);
    ArticyAssetHelper.NativeMethodInfoPtr_LoadAssetAsync_Public_Static_Task_1_ValueTuple_2_T_Object_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyAssetHelper>.NativeClassPtr, 100664306);
    ArticyAssetHelper.NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_ValueTuple_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyAssetHelper>.NativeClassPtr, 100664307);
    ArticyAssetHelper.NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyAssetHelper>.NativeClassPtr, 100664308);
    ArticyAssetHelper.NativeMethodInfoPtr_GetFinalFilePath_Private_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyAssetHelper>.NativeClassPtr, 100664309);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 998289, RefRangeEnd = 998301, XrefRangeStart = 998280, XrefRangeEnd = 998289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppSystem.ValueTuple<T, Il2CppSystem.Object> LoadAsset<T>(
    string aFileName,
    bool aIsGeneratedAsset = true)
    where T : UnityEngine.Object
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aFileName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aIsGeneratedAsset;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ArticyAssetHelper.MethodInfoStoreGeneric_LoadAsset_Public_Static_ValueTuple_2_T_Object_String_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new Il2CppSystem.ValueTuple<T, Il2CppSystem.Object>(pointer);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 998307, RefRangeEnd = 998317, XrefRangeStart = 998301, XrefRangeEnd = 998307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Task<Il2CppSystem.ValueTuple<T, Il2CppSystem.Object>> LoadAssetAsync<T>(
    string aFileName,
    bool aIsGeneratedAsset = true)
    where T : UnityEngine.Object
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aFileName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aIsGeneratedAsset;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyAssetHelper.MethodInfoStoreGeneric_LoadAssetAsync_Public_Static_Task_1_ValueTuple_2_T_Object_String_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Task<Il2CppSystem.ValueTuple<T, Il2CppSystem.Object>>) null : Il2CppObjectPool.Get<Task<Il2CppSystem.ValueTuple<T, Il2CppSystem.Object>>>(num3);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 998320, RefRangeEnd = 998334, XrefRangeStart = 998317, XrefRangeEnd = 998320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void UnloadAsset(Il2CppSystem.ValueTuple<UnityEngine.Object, Il2CppSystem.Object> aLoadAssetResult)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) aLoadAssetResult))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyAssetHelper.NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_ValueTuple_2_Object_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 998337, RefRangeEnd = 998338, XrefRangeStart = 998334, XrefRangeEnd = 998337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void UnloadAsset(UnityEngine.Object aAsset, Il2CppSystem.Object handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aAsset);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) handle);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyAssetHelper.NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 998347, RefRangeEnd = 998349, XrefRangeStart = 998338, XrefRangeEnd = 998347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetFinalFilePath(string aFile, bool aIsGeneratedAsset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aFile);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aIsGeneratedAsset;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyAssetHelper.NativeMethodInfoPtr_GetFinalFilePath_Private_Static_String_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public ArticyAssetHelper(System.IntPtr pointer)
    : base(pointer)
  {
  }

  [ObfuscatedName("Articy.Unity.Utils.ArticyAssetHelper+<LoadAssetAsync>d__1`1")]
  public sealed class _LoadAssetAsync_d__1<T> : Il2CppSystem.ValueType where T : UnityEngine.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_aFileName;
    private static readonly System.IntPtr NativeFieldInfoPtr_aIsGeneratedAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _LoadAssetAsync_d__1()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<ArticyAssetHelper._LoadAssetAsync_d__1<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyAssetHelper>.NativeClassPtr, "<LoadAssetAsync>d__1`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyAssetHelper._LoadAssetAsync_d__1<T>>.NativeClassPtr);
      ArticyAssetHelper._LoadAssetAsync_d__1<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyAssetHelper._LoadAssetAsync_d__1<T>>.NativeClassPtr, "<>1__state");
      ArticyAssetHelper._LoadAssetAsync_d__1<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyAssetHelper._LoadAssetAsync_d__1<T>>.NativeClassPtr, "<>t__builder");
      ArticyAssetHelper._LoadAssetAsync_d__1<T>.NativeFieldInfoPtr_aFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyAssetHelper._LoadAssetAsync_d__1<T>>.NativeClassPtr, nameof (aFileName));
      ArticyAssetHelper._LoadAssetAsync_d__1<T>.NativeFieldInfoPtr_aIsGeneratedAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyAssetHelper._LoadAssetAsync_d__1<T>>.NativeClassPtr, nameof (aIsGeneratedAsset));
      ArticyAssetHelper._LoadAssetAsync_d__1<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyAssetHelper._LoadAssetAsync_d__1<T>>.NativeClassPtr, "<>u__1");
      ArticyAssetHelper._LoadAssetAsync_d__1<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyAssetHelper._LoadAssetAsync_d__1<T>>.NativeClassPtr, 100664310);
      ArticyAssetHelper._LoadAssetAsync_d__1<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyAssetHelper._LoadAssetAsync_d__1<T>>.NativeClassPtr, 100664311);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998254, XrefRangeEnd = 998275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyAssetHelper._LoadAssetAsync_d__1<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998275, XrefRangeEnd = 998280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyAssetHelper._LoadAssetAsync_d__1<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _LoadAssetAsync_d__1(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _LoadAssetAsync_d__1()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyAssetHelper._LoadAssetAsync_d__1<T>>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyAssetHelper._LoadAssetAsync_d__1<T>.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyAssetHelper._LoadAssetAsync_d__1<T>.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder<Il2CppSystem.ValueTuple<T, Il2CppSystem.Object>> __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyAssetHelper._LoadAssetAsync_d__1<T>.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder<Il2CppSystem.ValueTuple<T, Il2CppSystem.Object>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppSystem.ValueTuple<T, Il2CppSystem.Object>>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyAssetHelper._LoadAssetAsync_d__1<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppSystem.ValueTuple<T, Il2CppSystem.Object>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe string aFileName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyAssetHelper._LoadAssetAsync_d__1<T>.NativeFieldInfoPtr_aFileName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyAssetHelper._LoadAssetAsync_d__1<T>.NativeFieldInfoPtr_aFileName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool aIsGeneratedAsset
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyAssetHelper._LoadAssetAsync_d__1<T>.NativeFieldInfoPtr_aIsGeneratedAsset));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyAssetHelper._LoadAssetAsync_d__1<T>.NativeFieldInfoPtr_aIsGeneratedAsset)) = value;
      }
    }

    public TaskAwaiter<Il2CppSystem.ValueTuple<T, Il2CppSystem.Object>> __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyAssetHelper._LoadAssetAsync_d__1<T>.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<Il2CppSystem.ValueTuple<T, Il2CppSystem.Object>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.ValueTuple<T, Il2CppSystem.Object>>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyAssetHelper._LoadAssetAsync_d__1<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.ValueTuple<T, Il2CppSystem.Object>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_LoadAsset_Public_Static_ValueTuple_2_T_Object_String_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyAssetHelper.NativeMethodInfoPtr_LoadAsset_Public_Static_ValueTuple_2_T_Object_String_Boolean_0, Il2CppClassPointerStore<ArticyAssetHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_LoadAssetAsync_Public_Static_Task_1_ValueTuple_2_T_Object_String_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyAssetHelper.NativeMethodInfoPtr_LoadAssetAsync_Public_Static_Task_1_ValueTuple_2_T_Object_String_Boolean_0, Il2CppClassPointerStore<ArticyAssetHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
