// Decompiled with JetBrains decompiler
// Type: LocalSingletonBehaviour`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class LocalSingletonBehaviour<T>(System.IntPtr pointer) : MonoBehaviour(pointer) where T : LocalSingletonBehaviour<T>
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instance;
  private static readonly System.IntPtr NativeFieldInfoPtr_awaken;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Inited_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Instance_Public_Static_set_Void_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_I_Public_Static_get_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Private_Static_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoAwake_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoDestroy_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LocalSingletonBehaviour()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<LocalSingletonBehaviour<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LocalSingletonBehaviour`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalSingletonBehaviour<T>>.NativeClassPtr);
    LocalSingletonBehaviour<T>.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalSingletonBehaviour<T>>.NativeClassPtr, nameof (instance));
    LocalSingletonBehaviour<T>.NativeFieldInfoPtr_awaken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalSingletonBehaviour<T>>.NativeClassPtr, nameof (awaken));
    LocalSingletonBehaviour<T>.NativeMethodInfoPtr_get_Inited_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalSingletonBehaviour<T>>.NativeClassPtr, 100663604);
    LocalSingletonBehaviour<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalSingletonBehaviour<T>>.NativeClassPtr, 100663605);
    LocalSingletonBehaviour<T>.NativeMethodInfoPtr_set_Instance_Public_Static_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalSingletonBehaviour<T>>.NativeClassPtr, 100663606);
    LocalSingletonBehaviour<T>.NativeMethodInfoPtr_get_I_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalSingletonBehaviour<T>>.NativeClassPtr, 100663607);
    LocalSingletonBehaviour<T>.NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalSingletonBehaviour<T>>.NativeClassPtr, 100663608);
    LocalSingletonBehaviour<T>.NativeMethodInfoPtr_Load_Private_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalSingletonBehaviour<T>>.NativeClassPtr, 100663609);
    LocalSingletonBehaviour<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalSingletonBehaviour<T>>.NativeClassPtr, 100663610);
    LocalSingletonBehaviour<T>.NativeMethodInfoPtr_OnDestroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalSingletonBehaviour<T>>.NativeClassPtr, 100663611);
    LocalSingletonBehaviour<T>.NativeMethodInfoPtr_DoAwake_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalSingletonBehaviour<T>>.NativeClassPtr, 100663612);
    LocalSingletonBehaviour<T>.NativeMethodInfoPtr_DoDestroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalSingletonBehaviour<T>>.NativeClassPtr, 100663613);
    LocalSingletonBehaviour<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalSingletonBehaviour<T>>.NativeClassPtr, 100663614);
  }

  public static unsafe bool Inited
  {
    [CallerCount(10), CachedScanResults(RefRangeStart = 21418, RefRangeEnd = 21428, XrefRangeStart = 21412, XrefRangeEnd = 21418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalSingletonBehaviour<T>.NativeMethodInfoPtr_get_Inited_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe T Instance
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 21436, RefRangeEnd = 21442, XrefRangeStart = 21428, XrefRangeEnd = 21436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalSingletonBehaviour<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21442, XrefRangeEnd = 21446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      T& local1;
      if (!typeof (T).IsValueType)
      {
        __Boxed<T> local2 = (object) value;
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LocalSingletonBehaviour<T>.NativeMethodInfoPtr_set_Instance_Public_Static_set_Void_T_0, System.IntPtr.Zero, (void**) numPtr1, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe T I
  {
    [CallerCount(271), CachedScanResults(RefRangeStart = 21455, RefRangeEnd = 21726, XrefRangeStart = 21446, XrefRangeEnd = 21455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalSingletonBehaviour<T>.NativeMethodInfoPtr_get_I_Public_Static_get_T_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21726, XrefRangeEnd = 21734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Init()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalSingletonBehaviour<T>.NativeMethodInfoPtr_Init_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 21764, RefRangeEnd = 21765, XrefRangeStart = 21734, XrefRangeEnd = 21764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T Load()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalSingletonBehaviour<T>.NativeMethodInfoPtr_Load_Private_Static_T_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21765, XrefRangeEnd = 21784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalSingletonBehaviour<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 21790, RefRangeEnd = 21791, XrefRangeStart = 21784, XrefRangeEnd = 21790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalSingletonBehaviour<T>.NativeMethodInfoPtr_OnDestroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void DoAwake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalSingletonBehaviour<T>.NativeMethodInfoPtr_DoAwake_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void DoDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalSingletonBehaviour<T>.NativeMethodInfoPtr_DoDestroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LocalSingletonBehaviour()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalSingletonBehaviour<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalSingletonBehaviour<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe T instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LocalSingletonBehaviour<T>.NativeFieldInfoPtr_instance, (void*) &num);
      return IL2CPP.PointerToValueGeneric<T>(num, false, false);
    }
    [param: In] set
    {
      System.IntPtr fieldInfoPtrInstance = LocalSingletonBehaviour<T>.NativeFieldInfoPtr_instance;
      T& local1;
      if (!typeof (T).IsValueType)
      {
        __Boxed<T> local2 = (object) value;
        if (!(local2 is string))
        {
          System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
          local1 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
        }
        else
          local1 = (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
      }
      else
        local1 = ref value;
      IL2CPP.il2cpp_field_static_set_value(fieldInfoPtrInstance, (void*) ref local1);
    }
  }

  public unsafe bool awaken
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalSingletonBehaviour<T>.NativeFieldInfoPtr_awaken));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalSingletonBehaviour<T>.NativeFieldInfoPtr_awaken)) = value;
    }
  }
}
