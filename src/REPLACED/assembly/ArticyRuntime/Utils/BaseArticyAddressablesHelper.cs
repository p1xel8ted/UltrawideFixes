// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Utils.BaseArticyAddressablesHelper
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity.Utils;

public class BaseArticyAddressablesHelper(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_sInstance;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_BaseArticyAddressablesHelper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadAddressable_Public_Abstract_Virtual_New_ValueTuple_2_T_Object_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadAddressableAsync_Public_Abstract_Virtual_New_Task_1_ValueTuple_2_T_Object_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadAddressable_Public_Abstract_Virtual_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static BaseArticyAddressablesHelper()
  {
    Il2CppClassPointerStore<BaseArticyAddressablesHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Utils", nameof (BaseArticyAddressablesHelper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseArticyAddressablesHelper>.NativeClassPtr);
    BaseArticyAddressablesHelper.NativeFieldInfoPtr_sInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseArticyAddressablesHelper>.NativeClassPtr, nameof (sInstance));
    BaseArticyAddressablesHelper.NativeMethodInfoPtr_Get_Public_Static_BaseArticyAddressablesHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseArticyAddressablesHelper>.NativeClassPtr, 100664312);
    BaseArticyAddressablesHelper.NativeMethodInfoPtr_LoadAddressable_Public_Abstract_Virtual_New_ValueTuple_2_T_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseArticyAddressablesHelper>.NativeClassPtr, 100664313);
    BaseArticyAddressablesHelper.NativeMethodInfoPtr_LoadAddressableAsync_Public_Abstract_Virtual_New_Task_1_ValueTuple_2_T_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseArticyAddressablesHelper>.NativeClassPtr, 100664314);
    BaseArticyAddressablesHelper.NativeMethodInfoPtr_UnloadAddressable_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseArticyAddressablesHelper>.NativeClassPtr, 100664315);
    BaseArticyAddressablesHelper.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseArticyAddressablesHelper>.NativeClassPtr, 100664316);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 998419, RefRangeEnd = 998423, XrefRangeStart = 998357, XrefRangeEnd = 998419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe BaseArticyAddressablesHelper Get()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseArticyAddressablesHelper.NativeMethodInfoPtr_Get_Public_Static_BaseArticyAddressablesHelper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (BaseArticyAddressablesHelper) null : Il2CppObjectPool.Get<BaseArticyAddressablesHelper>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe Il2CppSystem.ValueTuple<T, Il2CppSystem.Object> LoadAddressable<T>(
    string aAssetFileName)
    where T : UnityEngine.Object
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aAssetFileName)
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseArticyAddressablesHelper.MethodInfoStoreGeneric_LoadAddressable_Public_Abstract_Virtual_New_ValueTuple_2_T_Object_String_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new Il2CppSystem.ValueTuple<T, Il2CppSystem.Object>(pointer);
  }

  [CallerCount(0)]
  public virtual unsafe Task<Il2CppSystem.ValueTuple<T, Il2CppSystem.Object>> LoadAddressableAsync<T>(
    string aAssetFileName)
    where T : UnityEngine.Object
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aAssetFileName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseArticyAddressablesHelper.MethodInfoStoreGeneric_LoadAddressableAsync_Public_Abstract_Virtual_New_Task_1_ValueTuple_2_T_Object_String_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Task<Il2CppSystem.ValueTuple<T, Il2CppSystem.Object>>) null : Il2CppObjectPool.Get<Task<Il2CppSystem.ValueTuple<T, Il2CppSystem.Object>>>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe void UnloadAddressable(Il2CppSystem.Object handle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) handle)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseArticyAddressablesHelper.NativeMethodInfoPtr_UnloadAddressable_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BaseArticyAddressablesHelper()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseArticyAddressablesHelper>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseArticyAddressablesHelper.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe BaseArticyAddressablesHelper sInstance
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(BaseArticyAddressablesHelper.NativeFieldInfoPtr_sInstance, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (BaseArticyAddressablesHelper) null : Il2CppObjectPool.Get<BaseArticyAddressablesHelper>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BaseArticyAddressablesHelper.NativeFieldInfoPtr_sInstance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("Articy.Unity.Utils.BaseArticyAddressablesHelper+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Get_b__0_0_Internal_Boolean_Assembly_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Get_b__0_1_Internal_IEnumerable_1_Type_Assembly_0;

    static __c()
    {
      Il2CppClassPointerStore<BaseArticyAddressablesHelper.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseArticyAddressablesHelper>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseArticyAddressablesHelper.__c>.NativeClassPtr);
      BaseArticyAddressablesHelper.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseArticyAddressablesHelper.__c>.NativeClassPtr, "<>9");
      BaseArticyAddressablesHelper.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseArticyAddressablesHelper.__c>.NativeClassPtr, "<>9__0_0");
      BaseArticyAddressablesHelper.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseArticyAddressablesHelper.__c>.NativeClassPtr, "<>9__0_1");
      BaseArticyAddressablesHelper.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseArticyAddressablesHelper.__c>.NativeClassPtr, 100664318);
      BaseArticyAddressablesHelper.__c.NativeMethodInfoPtr__Get_b__0_0_Internal_Boolean_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseArticyAddressablesHelper.__c>.NativeClassPtr, 100664319);
      BaseArticyAddressablesHelper.__c.NativeMethodInfoPtr__Get_b__0_1_Internal_IEnumerable_1_Type_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseArticyAddressablesHelper.__c>.NativeClassPtr, 100664320 /*0x06000400*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseArticyAddressablesHelper.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BaseArticyAddressablesHelper.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool _Get_b__0_0(Assembly a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseArticyAddressablesHelper.__c.NativeMethodInfoPtr__Get_b__0_0_Internal_Boolean_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998349, XrefRangeEnd = 998350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerable<Il2CppSystem.Type> _Get_b__0_1(Assembly a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseArticyAddressablesHelper.__c.NativeMethodInfoPtr__Get_b__0_1_Internal_IEnumerable_1_Type_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IEnumerable<Il2CppSystem.Type>) null : Il2CppObjectPool.Get<IEnumerable<Il2CppSystem.Type>>(num3);
    }

    public static unsafe BaseArticyAddressablesHelper.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(BaseArticyAddressablesHelper.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (BaseArticyAddressablesHelper.__c) null : Il2CppObjectPool.Get<BaseArticyAddressablesHelper.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BaseArticyAddressablesHelper.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Assembly, bool> __9__0_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(BaseArticyAddressablesHelper.__c.NativeFieldInfoPtr___9__0_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<Assembly, bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Assembly, bool>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BaseArticyAddressablesHelper.__c.NativeFieldInfoPtr___9__0_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Assembly, IEnumerable<Il2CppSystem.Type>> __9__0_1
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(BaseArticyAddressablesHelper.__c.NativeFieldInfoPtr___9__0_1, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<Assembly, IEnumerable<Il2CppSystem.Type>>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Assembly, IEnumerable<Il2CppSystem.Type>>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BaseArticyAddressablesHelper.__c.NativeFieldInfoPtr___9__0_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.Utils.BaseArticyAddressablesHelper+<>c__DisplayClass0_0")]
  public sealed class __c__DisplayClass0_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_typeName;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Get_b__2_Internal_Boolean_Type_0;

    static __c__DisplayClass0_0()
    {
      Il2CppClassPointerStore<BaseArticyAddressablesHelper.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseArticyAddressablesHelper>.NativeClassPtr, "<>c__DisplayClass0_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseArticyAddressablesHelper.__c__DisplayClass0_0>.NativeClassPtr);
      BaseArticyAddressablesHelper.__c__DisplayClass0_0.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseArticyAddressablesHelper.__c__DisplayClass0_0>.NativeClassPtr, nameof (typeName));
      BaseArticyAddressablesHelper.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseArticyAddressablesHelper.__c__DisplayClass0_0>.NativeClassPtr, 100664321 /*0x06000401*/);
      BaseArticyAddressablesHelper.__c__DisplayClass0_0.NativeMethodInfoPtr__Get_b__2_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseArticyAddressablesHelper.__c__DisplayClass0_0>.NativeClassPtr, 100664322 /*0x06000402*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass0_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseArticyAddressablesHelper.__c__DisplayClass0_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BaseArticyAddressablesHelper.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998350, XrefRangeEnd = 998357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Get_b__2(Il2CppSystem.Type t)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseArticyAddressablesHelper.__c__DisplayClass0_0.NativeMethodInfoPtr__Get_b__2_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe string typeName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseArticyAddressablesHelper.__c__DisplayClass0_0.NativeFieldInfoPtr_typeName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseArticyAddressablesHelper.__c__DisplayClass0_0.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_LoadAddressable_Public_Abstract_Virtual_New_ValueTuple_2_T_Object_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BaseArticyAddressablesHelper.NativeMethodInfoPtr_LoadAddressable_Public_Abstract_Virtual_New_ValueTuple_2_T_Object_String_0, Il2CppClassPointerStore<BaseArticyAddressablesHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_LoadAddressableAsync_Public_Abstract_Virtual_New_Task_1_ValueTuple_2_T_Object_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BaseArticyAddressablesHelper.NativeMethodInfoPtr_LoadAddressableAsync_Public_Abstract_Virtual_New_Task_1_ValueTuple_2_T_Object_String_0, Il2CppClassPointerStore<BaseArticyAddressablesHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
