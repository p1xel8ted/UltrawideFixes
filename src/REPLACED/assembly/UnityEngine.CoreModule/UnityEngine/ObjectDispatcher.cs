// Decompiled with JetBrains decompiler
// Type: UnityEngine.ObjectDispatcher
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace UnityEngine;

public sealed class ObjectDispatcher(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_TypeDispatch;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_TransformDispatch;
  private static readonly ObjectDispatcher.CreateDispatchSystemHandleDelegate CreateDispatchSystemHandleDelegateField;
  private static readonly ObjectDispatcher.DestroyDispatchSystemHandleDelegate DestroyDispatchSystemHandleDelegateField;
  private static readonly ObjectDispatcher.GetMaxDispatchHistoryFramesCountDelegate GetMaxDispatchHistoryFramesCountDelegateField;
  private static readonly ObjectDispatcher.SetMaxDispatchHistoryFramesCountDelegate SetMaxDispatchHistoryFramesCountDelegateField;
  private static readonly ObjectDispatcher.EnableTypeTrackingDelegate EnableTypeTrackingDelegateField;
  private static readonly ObjectDispatcher.DisableTypeTrackingDelegate DisableTypeTrackingDelegateField;
  private static readonly ObjectDispatcher.EnableTransformTrackingDelegate EnableTransformTrackingDelegateField;
  private static readonly ObjectDispatcher.DisableTransformTrackingDelegate DisableTransformTrackingDelegateField;
  private static readonly ObjectDispatcher.DispatchTypeChangesAndClearDelegate DispatchTypeChangesAndClearDelegateField;
  private static readonly ObjectDispatcher.DispatchTransformDataChangesAndClearDelegate DispatchTransformDataChangesAndClearDelegateField;
  private static readonly ObjectDispatcher.DispatchTransformChangesAndClearDelegate DispatchTransformChangesAndClearDelegateField;

  static ObjectDispatcher()
  {
    Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ObjectDispatcher));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr);
    ObjectDispatcher.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, nameof (m_Ptr));
    ObjectDispatcher.NativeFieldInfoPtr_s_TypeDispatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, nameof (s_TypeDispatch));
    ObjectDispatcher.NativeFieldInfoPtr_s_TransformDispatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, nameof (s_TransformDispatch));
    ObjectDispatcher.CreateDispatchSystemHandleDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.CreateDispatchSystemHandleDelegate>("UnityEngine.ObjectDispatcher::CreateDispatchSystemHandle");
    ObjectDispatcher.DestroyDispatchSystemHandleDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.DestroyDispatchSystemHandleDelegate>("UnityEngine.ObjectDispatcher::DestroyDispatchSystemHandle");
    ObjectDispatcher.GetMaxDispatchHistoryFramesCountDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.GetMaxDispatchHistoryFramesCountDelegate>("UnityEngine.ObjectDispatcher::GetMaxDispatchHistoryFramesCount");
    ObjectDispatcher.SetMaxDispatchHistoryFramesCountDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.SetMaxDispatchHistoryFramesCountDelegate>("UnityEngine.ObjectDispatcher::SetMaxDispatchHistoryFramesCount");
    ObjectDispatcher.EnableTypeTrackingDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.EnableTypeTrackingDelegate>("UnityEngine.ObjectDispatcher::EnableTypeTracking");
    ObjectDispatcher.DisableTypeTrackingDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.DisableTypeTrackingDelegate>("UnityEngine.ObjectDispatcher::DisableTypeTracking");
    ObjectDispatcher.EnableTransformTrackingDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.EnableTransformTrackingDelegate>("UnityEngine.ObjectDispatcher::EnableTransformTracking");
    ObjectDispatcher.DisableTransformTrackingDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.DisableTransformTrackingDelegate>("UnityEngine.ObjectDispatcher::DisableTransformTracking");
    ObjectDispatcher.DispatchTypeChangesAndClearDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.DispatchTypeChangesAndClearDelegate>("UnityEngine.ObjectDispatcher::DispatchTypeChangesAndClear");
    ObjectDispatcher.DispatchTransformDataChangesAndClearDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.DispatchTransformDataChangesAndClearDelegate>("UnityEngine.ObjectDispatcher::DispatchTransformDataChangesAndClear");
    ObjectDispatcher.DispatchTransformChangesAndClearDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.DispatchTransformChangesAndClearDelegate>("UnityEngine.ObjectDispatcher::DispatchTransformChangesAndClear");
  }

  public unsafe System.IntPtr m_Ptr
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectDispatcher.NativeFieldInfoPtr_m_Ptr));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectDispatcher.NativeFieldInfoPtr_m_Ptr)) = value;
    }
  }

  public static unsafe Il2CppSystem.Action<Il2CppReferenceArray<Object>, System.IntPtr, System.IntPtr, int, int, Il2CppSystem.Action<TypeDispatchData>> s_TypeDispatch
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ObjectDispatcher.NativeFieldInfoPtr_s_TypeDispatch, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<Il2CppReferenceArray<Object>, System.IntPtr, System.IntPtr, int, int, Il2CppSystem.Action<TypeDispatchData>>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<Il2CppReferenceArray<Object>, System.IntPtr, System.IntPtr, int, int, Il2CppSystem.Action<TypeDispatchData>>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ObjectDispatcher.NativeFieldInfoPtr_s_TypeDispatch, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppSystem.Action<System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, int, Il2CppSystem.Action<TransformDispatchData>> s_TransformDispatch
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ObjectDispatcher.NativeFieldInfoPtr_s_TransformDispatch, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, int, Il2CppSystem.Action<TransformDispatchData>>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, int, Il2CppSystem.Action<TransformDispatchData>>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ObjectDispatcher.NativeFieldInfoPtr_s_TransformDispatch, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public bool valid => this.m_Ptr != Il2CppSystem.IntPtr.Zero;

  public int maxDispatchHistoryFramesCount
  {
    get
    {
      this.ValidateSystemHandleAndThrow();
      return ObjectDispatcher.GetMaxDispatchHistoryFramesCount(this.m_Ptr);
    }
    set
    {
      this.ValidateSystemHandleAndThrow();
      ObjectDispatcher.SetMaxDispatchHistoryFramesCount(this.m_Ptr, value);
    }
  }

  public new virtual void Finalize()
  {
    try
    {
      this.Dispose(false);
    }
    finally
    {
      base.Finalize();
    }
  }

  public void Dispose()
  {
    this.Dispose(true);
    Il2CppSystem.GC.SuppressFinalize((Il2CppSystem.Object) this);
  }

  public void Dispose(bool disposing)
  {
    if (!(this.m_Ptr != Il2CppSystem.IntPtr.Zero))
      return;
    ObjectDispatcher.DestroyDispatchSystemHandle(this.m_Ptr);
    this.m_Ptr = Il2CppSystem.IntPtr.Zero;
  }

  public void ValidateSystemHandleAndThrow()
  {
    if (!this.valid)
      throw new Il2CppSystem.Exception("The ObjectDispatcher is invalid or has been disposed.");
  }

  public void ValidateTypeAndThrow(Il2CppSystem.Type type)
  {
    if (!type.IsSubclassOf(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>())))
      throw new Il2CppSystem.Exception("Only types inherited from UnityEngine.Object are supported.");
  }

  public void ValidateComponentTypeAndThrow(Il2CppSystem.Type type)
  {
    if (!type.IsSubclassOf(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Component>())))
      throw new Il2CppSystem.Exception("Only types inherited from UnityEngine.Component are supported.");
  }

  public void DispatchCallback(TypeDispatchData data)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void DispatchCallback(TransformDispatchData data)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void DispatchCallback(Il2CppReferenceArray<Component> components)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void DispatchTypeChangesAndClear(
    Il2CppSystem.Type type,
    Il2CppSystem.Action<TypeDispatchData> callback,
    bool sortByInstanceID = default (bool),
    bool noScriptingArray = default (bool))
  {
    this.ValidateSystemHandleAndThrow();
    this.ValidateTypeAndThrow(type);
    ObjectDispatcher.DispatchTypeChangesAndClear(this.m_Ptr, type, ObjectDispatcher.s_TypeDispatch, sortByInstanceID, noScriptingArray, callback);
  }

  public void DispatchTransformChangesAndClear(
    Il2CppSystem.Type type,
    ObjectDispatcher.TransformTrackingType trackingType,
    Il2CppSystem.Action<Il2CppReferenceArray<Component>> callback,
    bool sortByInstanceID = default (bool))
  {
    this.ValidateSystemHandleAndThrow();
    this.ValidateComponentTypeAndThrow(type);
    ObjectDispatcher.DispatchTransformChangesAndClear(this.m_Ptr, type, trackingType, callback, sortByInstanceID);
  }

  public void DispatchTransformChangesAndClear(
    Il2CppSystem.Type type,
    ObjectDispatcher.TransformTrackingType trackingType,
    Il2CppSystem.Action<TransformDispatchData> callback)
  {
    this.ValidateSystemHandleAndThrow();
    this.ValidateComponentTypeAndThrow(type);
    ObjectDispatcher.DispatchTransformDataChangesAndClear(this.m_Ptr, type, trackingType, ObjectDispatcher.s_TransformDispatch, callback);
  }

  public void ClearTypeChanges(Il2CppSystem.Type type)
  {
    this.ValidateSystemHandleAndThrow();
    this.ValidateTypeAndThrow(type);
    ObjectDispatcher.DispatchTypeChangesAndClear(this.m_Ptr, type, (Il2CppSystem.Action<Il2CppReferenceArray<Object>, System.IntPtr, System.IntPtr, int, int, Il2CppSystem.Action<TypeDispatchData>>) null, false, false, (Il2CppSystem.Action<TypeDispatchData>) null);
  }

  public TypeDispatchData GetTypeChangesAndClear(
    Il2CppSystem.Type type,
    Allocator allocator,
    bool sortByInstanceID = default (bool),
    bool noScriptingArray = default (bool))
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void GetTypeChangesAndClear(
    Il2CppSystem.Type type,
    List<Object> changed,
    out NativeArray<int> changedID,
    out NativeArray<int> destroyedID,
    Allocator allocator,
    bool sortByInstanceID = default (bool))
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public Il2CppReferenceArray<Component> GetTransformChangesAndClear(
    Il2CppSystem.Type type,
    ObjectDispatcher.TransformTrackingType trackingType,
    bool sortByInstanceID = default (bool))
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public TransformDispatchData GetTransformChangesAndClear(
    Il2CppSystem.Type type,
    ObjectDispatcher.TransformTrackingType trackingType,
    Allocator allocator)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void EnableTypeTracking(
    ObjectDispatcher.TypeTrackingFlags typeTrackingMask,
    Il2CppReferenceArray<Il2CppSystem.Type> types)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void EnableTypeTracking(
    ObjectDispatcher.TypeTrackingFlags typeTrackingMask,
    params Il2CppSystem.Type[] types)
  {
    this.EnableTypeTracking(typeTrackingMask, new Il2CppReferenceArray<Il2CppSystem.Type>(types));
  }

  public void EnableTypeTracking(Il2CppReferenceArray<Il2CppSystem.Type> types)
  {
    this.EnableTypeTracking(ObjectDispatcher.TypeTrackingFlags.Default, types);
  }

  public void EnableTypeTracking(params Il2CppSystem.Type[] types)
  {
    this.EnableTypeTracking(new Il2CppReferenceArray<Il2CppSystem.Type>(types));
  }

  public void EnableTypeTrackingIncludingAssets(Il2CppReferenceArray<Il2CppSystem.Type> types)
  {
    this.EnableTypeTracking(ObjectDispatcher.TypeTrackingFlags.Default, types);
  }

  public void EnableTypeTrackingIncludingAssets(params Il2CppSystem.Type[] types)
  {
    this.EnableTypeTrackingIncludingAssets(new Il2CppReferenceArray<Il2CppSystem.Type>(types));
  }

  public void DisableTypeTracking(Il2CppReferenceArray<Il2CppSystem.Type> types)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void DisableTypeTracking(params Il2CppSystem.Type[] types)
  {
    this.DisableTypeTracking(new Il2CppReferenceArray<Il2CppSystem.Type>(types));
  }

  public void EnableTransformTracking(
    ObjectDispatcher.TransformTrackingType trackingType,
    Il2CppReferenceArray<Il2CppSystem.Type> types)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void EnableTransformTracking(
    ObjectDispatcher.TransformTrackingType trackingType,
    params Il2CppSystem.Type[] types)
  {
    this.EnableTransformTracking(trackingType, new Il2CppReferenceArray<Il2CppSystem.Type>(types));
  }

  public void DisableTransformTracking(
    ObjectDispatcher.TransformTrackingType trackingType,
    Il2CppReferenceArray<Il2CppSystem.Type> types)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void DisableTransformTracking(
    ObjectDispatcher.TransformTrackingType trackingType,
    params Il2CppSystem.Type[] types)
  {
    this.DisableTransformTracking(trackingType, new Il2CppReferenceArray<Il2CppSystem.Type>(types));
  }

  public void DispatchTypeChangesAndClear<T>(
    Il2CppSystem.Action<TypeDispatchData> callback,
    bool sortByInstanceID = default (bool),
    bool noScriptingArray = default (bool))
    where T : Object
  {
    this.DispatchTypeChangesAndClear(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), callback, sortByInstanceID, noScriptingArray);
  }

  public void DispatchTransformChangesAndClear<T>(
    ObjectDispatcher.TransformTrackingType trackingType,
    Il2CppSystem.Action<Il2CppReferenceArray<Component>> callback,
    bool sortByInstanceID = default (bool))
    where T : Object
  {
    this.DispatchTransformChangesAndClear(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), trackingType, callback, sortByInstanceID);
  }

  public void DispatchTransformChangesAndClear<T>(
    ObjectDispatcher.TransformTrackingType trackingType,
    Il2CppSystem.Action<TransformDispatchData> callback)
    where T : Object
  {
    this.DispatchTransformChangesAndClear(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), trackingType, callback);
  }

  public void ClearTypeChanges<T>() where T : Object
  {
    this.ClearTypeChanges(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
  }

  public TypeDispatchData GetTypeChangesAndClear<T>(
    Allocator allocator,
    bool sortByInstanceID = default (bool),
    bool noScriptingArray = default (bool))
    where T : Object
  {
    return this.GetTypeChangesAndClear(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), allocator, sortByInstanceID, noScriptingArray);
  }

  public void GetTypeChangesAndClear<T>(
    List<Object> changed,
    out NativeArray<int> changedID,
    out NativeArray<int> destroyedID,
    Allocator allocator,
    bool sortByInstanceID = default (bool))
    where T : Object
  {
    this.GetTypeChangesAndClear(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), changed, out changedID, out destroyedID, allocator, sortByInstanceID);
  }

  public Il2CppReferenceArray<Component> GetTransformChangesAndClear<T>(
    ObjectDispatcher.TransformTrackingType trackingType,
    bool sortByInstanceID = default (bool))
    where T : Object
  {
    return this.GetTransformChangesAndClear(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), trackingType, sortByInstanceID);
  }

  public TransformDispatchData GetTransformChangesAndClear<T>(
    ObjectDispatcher.TransformTrackingType trackingType,
    Allocator allocator)
    where T : Object
  {
    return this.GetTransformChangesAndClear(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), trackingType, allocator);
  }

  public void EnableTypeTracking<T>(
    ObjectDispatcher.TypeTrackingFlags typeTrackingMask = default (ObjectDispatcher.TypeTrackingFlags))
    where T : Object
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void DisableTypeTracking<T>() where T : Object
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void EnableTransformTracking<T>(
    ObjectDispatcher.TransformTrackingType trackingType)
    where T : Object
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void DisableTransformTracking<T>(
    ObjectDispatcher.TransformTrackingType trackingType)
    where T : Object
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static System.IntPtr CreateDispatchSystemHandle()
  {
    return ObjectDispatcher.CreateDispatchSystemHandleDelegateField();
  }

  public static void DestroyDispatchSystemHandle(System.IntPtr ptr)
  {
    ObjectDispatcher.DestroyDispatchSystemHandleDelegateField(ptr);
  }

  public static int GetMaxDispatchHistoryFramesCount(System.IntPtr ptr)
  {
    return ObjectDispatcher.GetMaxDispatchHistoryFramesCountDelegateField(ptr);
  }

  public static void SetMaxDispatchHistoryFramesCount(System.IntPtr ptr, int count)
  {
    ObjectDispatcher.SetMaxDispatchHistoryFramesCountDelegateField(ptr, count);
  }

  public static void EnableTypeTracking(
    System.IntPtr ptr,
    Il2CppSystem.Type type,
    ObjectDispatcher.TypeTrackingFlags typeTrackingMask)
  {
    ObjectDispatcher.EnableTypeTrackingDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type), typeTrackingMask);
  }

  public static void DisableTypeTracking(System.IntPtr ptr, Il2CppSystem.Type type)
  {
    ObjectDispatcher.DisableTypeTrackingDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type));
  }

  public static void EnableTransformTracking(
    System.IntPtr ptr,
    Il2CppSystem.Type type,
    ObjectDispatcher.TransformTrackingType trackingType)
  {
    ObjectDispatcher.EnableTransformTrackingDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type), trackingType);
  }

  public static void DisableTransformTracking(
    System.IntPtr ptr,
    Il2CppSystem.Type type,
    ObjectDispatcher.TransformTrackingType trackingType)
  {
    ObjectDispatcher.DisableTransformTrackingDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type), trackingType);
  }

  public static void DispatchTypeChangesAndClear(
    System.IntPtr ptr,
    Il2CppSystem.Type type,
    Il2CppSystem.Action<Il2CppReferenceArray<Object>, System.IntPtr, System.IntPtr, int, int, Il2CppSystem.Action<TypeDispatchData>> callback,
    bool sortByInstanceID,
    bool noScriptingArray,
    Il2CppSystem.Action<TypeDispatchData> param)
  {
    ObjectDispatcher.DispatchTypeChangesAndClearDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback), sortByInstanceID, noScriptingArray, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) param));
  }

  public static void DispatchTransformDataChangesAndClear(
    System.IntPtr ptr,
    Il2CppSystem.Type type,
    ObjectDispatcher.TransformTrackingType trackingType,
    Il2CppSystem.Action<System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, int, Il2CppSystem.Action<TransformDispatchData>> callback,
    Il2CppSystem.Action<TransformDispatchData> param)
  {
    ObjectDispatcher.DispatchTransformDataChangesAndClearDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type), trackingType, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) param));
  }

  public static void DispatchTransformChangesAndClear(
    System.IntPtr ptr,
    Il2CppSystem.Type type,
    ObjectDispatcher.TransformTrackingType trackingType,
    Il2CppSystem.Action<Il2CppReferenceArray<Component>> callback,
    bool sortByInstanceID)
  {
    ObjectDispatcher.DispatchTransformChangesAndClearDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type), trackingType, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback), sortByInstanceID);
  }

  [ObfuscatedName("UnityEngine.ObjectDispatcher+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__64_0_Internal_Void_Il2CppReferenceArray_1_Object_IntPtr_IntPtr_Int32_Int32_Action_1_TypeDispatchData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__64_1_Internal_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int32_Action_1_TransformDispatchData_0;

    static __c()
    {
      Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr);
      ObjectDispatcher.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr, "<>9");
      ObjectDispatcher.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr, 100667671);
      ObjectDispatcher.__c.NativeMethodInfoPtr___cctor_b__64_0_Internal_Void_Il2CppReferenceArray_1_Object_IntPtr_IntPtr_Int32_Int32_Action_1_TypeDispatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr, 100667672);
      ObjectDispatcher.__c.NativeMethodInfoPtr___cctor_b__64_1_Internal_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int32_Action_1_TransformDispatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr, 100667673);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ObjectDispatcher.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441382, XrefRangeEnd = 441387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __cctor_b__64_0(
      Il2CppReferenceArray<Object> changed,
      System.IntPtr changedID,
      System.IntPtr destroyedID,
      int changedCount,
      int destroyedCount,
      Il2CppSystem.Action<TypeDispatchData> callback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) changed);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &changedID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &destroyedID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &changedCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &destroyedCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ObjectDispatcher.__c.NativeMethodInfoPtr___cctor_b__64_0_Internal_Void_Il2CppReferenceArray_1_Object_IntPtr_IntPtr_Int32_Int32_Action_1_TypeDispatchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441387, XrefRangeEnd = 441403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __cctor_b__64_1(
      System.IntPtr transformed,
      System.IntPtr parents,
      System.IntPtr localToWorldMatrices,
      System.IntPtr positions,
      System.IntPtr rotations,
      System.IntPtr scales,
      int count,
      Il2CppSystem.Action<TransformDispatchData> callback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &transformed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &parents;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localToWorldMatrices;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &positions;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rotations;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &scales;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ObjectDispatcher.__c.NativeMethodInfoPtr___cctor_b__64_1_Internal_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int32_Action_1_TransformDispatchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static unsafe ObjectDispatcher.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ObjectDispatcher.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (ObjectDispatcher.__c) null : Il2CppObjectPool.Get<ObjectDispatcher.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ObjectDispatcher.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public enum TransformTrackingType
  {
    GlobalTRS,
    LocalTRS,
    Hierarchy,
  }

  public enum TypeTrackingFlags
  {
    SceneObjects = 1,
    Assets = 2,
    Default = 3,
    EditorOnlyObjects = 4,
    All = 7,
  }

  [Serializable]
  public sealed class \u003C\u003Ec
  {
  }

  private delegate System.IntPtr CreateDispatchSystemHandleDelegate();

  private delegate void DestroyDispatchSystemHandleDelegate(System.IntPtr ptr);

  private delegate int GetMaxDispatchHistoryFramesCountDelegate(System.IntPtr ptr);

  private delegate void SetMaxDispatchHistoryFramesCountDelegate(System.IntPtr ptr, int count);

  private delegate void EnableTypeTrackingDelegate(
    System.IntPtr ptr,
    System.IntPtr type,
    ObjectDispatcher.TypeTrackingFlags typeTrackingMask);

  private delegate void DisableTypeTrackingDelegate(System.IntPtr ptr, System.IntPtr type);

  private delegate void EnableTransformTrackingDelegate(
    System.IntPtr ptr,
    System.IntPtr type,
    ObjectDispatcher.TransformTrackingType trackingType);

  private delegate void DisableTransformTrackingDelegate(
    System.IntPtr ptr,
    System.IntPtr type,
    ObjectDispatcher.TransformTrackingType trackingType);

  private delegate void DispatchTypeChangesAndClearDelegate(
    System.IntPtr ptr,
    System.IntPtr type,
    System.IntPtr callback,
    bool sortByInstanceID,
    bool noScriptingArray,
    System.IntPtr param);

  private delegate void DispatchTransformDataChangesAndClearDelegate(
    System.IntPtr ptr,
    System.IntPtr type,
    ObjectDispatcher.TransformTrackingType trackingType,
    System.IntPtr callback,
    System.IntPtr param);

  private delegate void DispatchTransformChangesAndClearDelegate(
    System.IntPtr ptr,
    System.IntPtr type,
    ObjectDispatcher.TransformTrackingType trackingType,
    System.IntPtr callback,
    bool sortByInstanceID);
}
