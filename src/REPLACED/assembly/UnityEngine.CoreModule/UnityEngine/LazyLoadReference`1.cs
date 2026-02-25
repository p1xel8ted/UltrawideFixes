// Decompiled with JetBrains decompiler
// Type: UnityEngine.LazyLoadReference`1
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[Serializable]
public sealed class LazyLoadReference<T> : Il2CppSystem.ValueType where T : Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kInstanceID_None;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceID;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isSet_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_asset_Public_get_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_asset_Public_set_Void_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LazyLoadReference_1_T_T_0;

  static LazyLoadReference()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LazyLoadReference`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr);
    LazyLoadReference<T>.NativeFieldInfoPtr_kInstanceID_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr, nameof (kInstanceID_None));
    LazyLoadReference<T>.NativeFieldInfoPtr_m_InstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr, nameof (m_InstanceID));
    LazyLoadReference<T>.NativeMethodInfoPtr_get_isSet_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr, 100668178);
    LazyLoadReference<T>.NativeMethodInfoPtr_get_asset_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr, 100668179);
    LazyLoadReference<T>.NativeMethodInfoPtr_set_asset_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr, 100668180);
    LazyLoadReference<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_LazyLoadReference_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr, 100668181);
  }

  public unsafe bool isSet
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 452059, RefRangeEnd = 452060, XrefRangeStart = 452059, XrefRangeEnd = 452059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LazyLoadReference<T>.NativeMethodInfoPtr_get_isSet_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe T asset
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452060, XrefRangeEnd = 452068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LazyLoadReference<T>.NativeMethodInfoPtr_get_asset_Public_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452068, XrefRangeEnd = 452076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
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
      IL2CPP.il2cpp_runtime_invoke(LazyLoadReference<T>.NativeMethodInfoPtr_set_asset_Public_set_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr1, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 452078, RefRangeEnd = 452079, XrefRangeStart = 452076, XrefRangeEnd = 452078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator LazyLoadReference<T>(T asset)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) asset;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref asset;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LazyLoadReference<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_LazyLoadReference_1_T_T_0, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new LazyLoadReference<T>(pointer);
  }

  public LazyLoadReference(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public LazyLoadReference()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr))
  {
  }

  public static unsafe int kInstanceID_None
  {
    get
    {
      int kInstanceIdNone;
      IL2CPP.il2cpp_field_static_get_value(LazyLoadReference<T>.NativeFieldInfoPtr_kInstanceID_None, (void*) &kInstanceIdNone);
      return kInstanceIdNone;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LazyLoadReference<T>.NativeFieldInfoPtr_kInstanceID_None, (void*) &value);
    }
  }

  public unsafe int m_InstanceID
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LazyLoadReference<T>.NativeFieldInfoPtr_m_InstanceID));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LazyLoadReference<T>.NativeFieldInfoPtr_m_InstanceID)) = value;
    }
  }

  public bool isBroken
  {
    get
    {
      return ((LazyLoadReference<>) this).m_InstanceID != 0 && !Object.DoesObjectWithInstanceIDExist(((LazyLoadReference<>) this).m_InstanceID);
    }
  }

  public int instanceID
  {
    get => ((LazyLoadReference<>) this).m_InstanceID;
    set => ((LazyLoadReference<>) this).m_InstanceID = value;
  }

  public static implicit operator LazyLoadReference<T>(int instanceID)
  {
    LazyLoadReference<T> lazyLoadReference = (LazyLoadReference<T>) null;
    ((LazyLoadReference<T>) ref lazyLoadReference).instanceID = instanceID;
    return lazyLoadReference;
  }
}
