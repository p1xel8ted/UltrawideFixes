// Decompiled with JetBrains decompiler
// Type: GlobalSingletonBehaviour`1
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
public class GlobalSingletonBehaviour<T>(System.IntPtr pointer) : MonoBehaviour(pointer) where T : GlobalSingletonBehaviour<T>
{
  private static readonly System.IntPtr NativeFieldInfoPtr_destroyed;
  private static readonly System.IntPtr NativeFieldInfoPtr_instance;
  private static readonly System.IntPtr NativeFieldInfoPtr_awaken;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Instance_Public_Static_set_Void_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_I_Public_Static_get_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Private_Static_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoAwake_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoDestroy_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GlobalSingletonBehaviour()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<GlobalSingletonBehaviour<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GlobalSingletonBehaviour`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalSingletonBehaviour<T>>.NativeClassPtr);
    GlobalSingletonBehaviour<T>.NativeFieldInfoPtr_destroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalSingletonBehaviour<T>>.NativeClassPtr, nameof (destroyed));
    GlobalSingletonBehaviour<T>.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalSingletonBehaviour<T>>.NativeClassPtr, nameof (instance));
    GlobalSingletonBehaviour<T>.NativeFieldInfoPtr_awaken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalSingletonBehaviour<T>>.NativeClassPtr, nameof (awaken));
    GlobalSingletonBehaviour<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSingletonBehaviour<T>>.NativeClassPtr, 100663565 /*0x0600010D*/);
    GlobalSingletonBehaviour<T>.NativeMethodInfoPtr_set_Instance_Public_Static_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSingletonBehaviour<T>>.NativeClassPtr, 100663566 /*0x0600010E*/);
    GlobalSingletonBehaviour<T>.NativeMethodInfoPtr_get_I_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSingletonBehaviour<T>>.NativeClassPtr, 100663567 /*0x0600010F*/);
    GlobalSingletonBehaviour<T>.NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSingletonBehaviour<T>>.NativeClassPtr, 100663568 /*0x06000110*/);
    GlobalSingletonBehaviour<T>.NativeMethodInfoPtr_Load_Private_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSingletonBehaviour<T>>.NativeClassPtr, 100663569);
    GlobalSingletonBehaviour<T>.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSingletonBehaviour<T>>.NativeClassPtr, 100663570);
    GlobalSingletonBehaviour<T>.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSingletonBehaviour<T>>.NativeClassPtr, 100663571);
    GlobalSingletonBehaviour<T>.NativeMethodInfoPtr_DoAwake_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSingletonBehaviour<T>>.NativeClassPtr, 100663572);
    GlobalSingletonBehaviour<T>.NativeMethodInfoPtr_DoDestroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSingletonBehaviour<T>>.NativeClassPtr, 100663573);
    GlobalSingletonBehaviour<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSingletonBehaviour<T>>.NativeClassPtr, 100663574);
  }

  public static unsafe T Instance
  {
    [CallerCount(38), CachedScanResults(RefRangeStart = 20463, RefRangeEnd = 20501, XrefRangeStart = 20451, XrefRangeEnd = 20463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlobalSingletonBehaviour<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20501, XrefRangeEnd = 20505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
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
      IL2CPP.il2cpp_runtime_invoke(GlobalSingletonBehaviour<T>.NativeMethodInfoPtr_set_Instance_Public_Static_set_Void_T_0, System.IntPtr.Zero, (void**) numPtr1, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe T I
  {
    [CallerCount(395), CachedScanResults(RefRangeStart = 20507, RefRangeEnd = 20902, XrefRangeStart = 20505, XrefRangeEnd = 20507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlobalSingletonBehaviour<T>.NativeMethodInfoPtr_get_I_Public_Static_get_T_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 20910, RefRangeEnd = 20912, XrefRangeStart = 20902, XrefRangeEnd = 20910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Init()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalSingletonBehaviour<T>.NativeMethodInfoPtr_Init_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20912, XrefRangeEnd = 20928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T Load()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlobalSingletonBehaviour<T>.NativeMethodInfoPtr_Load_Private_Static_T_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20928, XrefRangeEnd = 20955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlobalSingletonBehaviour<T>.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20955, XrefRangeEnd = 20961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalSingletonBehaviour<T>.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void DoAwake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlobalSingletonBehaviour<T>.NativeMethodInfoPtr_DoAwake_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void DoDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlobalSingletonBehaviour<T>.NativeMethodInfoPtr_DoDestroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GlobalSingletonBehaviour()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalSingletonBehaviour<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalSingletonBehaviour<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe bool destroyed
  {
    get
    {
      bool destroyed;
      IL2CPP.il2cpp_field_static_get_value(GlobalSingletonBehaviour<T>.NativeFieldInfoPtr_destroyed, (void*) &destroyed);
      return destroyed;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlobalSingletonBehaviour<T>.NativeFieldInfoPtr_destroyed, (void*) &value);
    }
  }

  public static unsafe T instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GlobalSingletonBehaviour<T>.NativeFieldInfoPtr_instance, (void*) &num);
      return IL2CPP.PointerToValueGeneric<T>(num, false, false);
    }
    [param: In] set
    {
      System.IntPtr fieldInfoPtrInstance = GlobalSingletonBehaviour<T>.NativeFieldInfoPtr_instance;
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
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalSingletonBehaviour<T>.NativeFieldInfoPtr_awaken));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalSingletonBehaviour<T>.NativeFieldInfoPtr_awaken)) = value;
    }
  }
}
