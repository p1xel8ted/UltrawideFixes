// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.SortingGroup
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Rendering;

public sealed class SortingGroup(System.IntPtr pointer) : Behaviour(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_get_invalidSortingGroupID_Internal_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSortingGroupByIndex_Internal_Static_SortingGroup_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSortingGroupByIndex_Injected_Private_Static_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingLayerID_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingOrder_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly SortingGroup.UpdateAllSortingGroupsDelegate UpdateAllSortingGroupsDelegateField;
  private static readonly SortingGroup.get_sortingLayerName_InjectedDelegate get_sortingLayerName_InjectedDelegateField;
  private static readonly SortingGroup.set_sortingLayerName_InjectedDelegate set_sortingLayerName_InjectedDelegateField;
  private static readonly SortingGroup.set_sortingLayerID_InjectedDelegate set_sortingLayerID_InjectedDelegateField;
  private static readonly SortingGroup.set_sortingOrder_InjectedDelegate set_sortingOrder_InjectedDelegateField;
  private static readonly SortingGroup.get_sortAtRoot_InjectedDelegate get_sortAtRoot_InjectedDelegateField;
  private static readonly SortingGroup.set_sortAtRoot_InjectedDelegate set_sortAtRoot_InjectedDelegateField;
  private static readonly SortingGroup.get_sortingGroupID_InjectedDelegate get_sortingGroupID_InjectedDelegateField;
  private static readonly SortingGroup.get_sortingGroupOrder_InjectedDelegate get_sortingGroupOrder_InjectedDelegateField;
  private static readonly SortingGroup.get_index_InjectedDelegate get_index_InjectedDelegateField;
  private static readonly SortingGroup.get_sortingKey_InjectedDelegate get_sortingKey_InjectedDelegateField;

  static SortingGroup()
  {
    Il2CppClassPointerStore<SortingGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (SortingGroup));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr);
    SortingGroup.NativeMethodInfoPtr_get_invalidSortingGroupID_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100669604);
    SortingGroup.NativeMethodInfoPtr_GetSortingGroupByIndex_Internal_Static_SortingGroup_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100669605);
    SortingGroup.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100669606);
    SortingGroup.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100669607);
    SortingGroup.NativeMethodInfoPtr_GetSortingGroupByIndex_Injected_Private_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100669608);
    SortingGroup.NativeMethodInfoPtr_get_sortingLayerID_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100669609);
    SortingGroup.NativeMethodInfoPtr_get_sortingOrder_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100669610);
    SortingGroup.UpdateAllSortingGroupsDelegateField = IL2CPP.ResolveICall<SortingGroup.UpdateAllSortingGroupsDelegate>("UnityEngine.Rendering.SortingGroup::UpdateAllSortingGroups");
    SortingGroup.get_sortingLayerName_InjectedDelegateField = IL2CPP.ResolveICall<SortingGroup.get_sortingLayerName_InjectedDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingLayerName_Injected");
    SortingGroup.set_sortingLayerName_InjectedDelegateField = IL2CPP.ResolveICall<SortingGroup.set_sortingLayerName_InjectedDelegate>("UnityEngine.Rendering.SortingGroup::set_sortingLayerName_Injected");
    SortingGroup.set_sortingLayerID_InjectedDelegateField = IL2CPP.ResolveICall<SortingGroup.set_sortingLayerID_InjectedDelegate>("UnityEngine.Rendering.SortingGroup::set_sortingLayerID_Injected");
    SortingGroup.set_sortingOrder_InjectedDelegateField = IL2CPP.ResolveICall<SortingGroup.set_sortingOrder_InjectedDelegate>("UnityEngine.Rendering.SortingGroup::set_sortingOrder_Injected");
    SortingGroup.get_sortAtRoot_InjectedDelegateField = IL2CPP.ResolveICall<SortingGroup.get_sortAtRoot_InjectedDelegate>("UnityEngine.Rendering.SortingGroup::get_sortAtRoot_Injected");
    SortingGroup.set_sortAtRoot_InjectedDelegateField = IL2CPP.ResolveICall<SortingGroup.set_sortAtRoot_InjectedDelegate>("UnityEngine.Rendering.SortingGroup::set_sortAtRoot_Injected");
    SortingGroup.get_sortingGroupID_InjectedDelegateField = IL2CPP.ResolveICall<SortingGroup.get_sortingGroupID_InjectedDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingGroupID_Injected");
    SortingGroup.get_sortingGroupOrder_InjectedDelegateField = IL2CPP.ResolveICall<SortingGroup.get_sortingGroupOrder_InjectedDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingGroupOrder_Injected");
    SortingGroup.get_index_InjectedDelegateField = IL2CPP.ResolveICall<SortingGroup.get_index_InjectedDelegate>("UnityEngine.Rendering.SortingGroup::get_index_Injected");
    SortingGroup.get_sortingKey_InjectedDelegateField = IL2CPP.ResolveICall<SortingGroup.get_sortingKey_InjectedDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingKey_Injected");
  }

  public static unsafe int invalidSortingGroupID
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 481935, RefRangeEnd = 481939, XrefRangeStart = 481933, XrefRangeEnd = 481935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_invalidSortingGroupID_Internal_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 481944, RefRangeEnd = 481945, XrefRangeStart = 481939, XrefRangeEnd = 481944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe SortingGroup GetSortingGroupByIndex(int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_GetSortingGroupByIndex_Internal_Static_SortingGroup_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (SortingGroup) null : Il2CppObjectPool.Get<SortingGroup>(num3);
  }

  public unsafe int sortingLayerID
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 481950, RefRangeEnd = 481951, XrefRangeStart = 481945, XrefRangeEnd = 481950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SortingGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      SortingGroup.set_sortingLayerID_Injected(_unity_self, value);
    }
  }

  public unsafe int sortingOrder
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 481956, RefRangeEnd = 481957, XrefRangeStart = 481951, XrefRangeEnd = 481956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SortingGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      SortingGroup.set_sortingOrder_Injected(_unity_self, value);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481957, XrefRangeEnd = 481959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr GetSortingGroupByIndex_Injected(int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_GetSortingGroupByIndex_Injected_Private_Static_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481959, XrefRangeEnd = 481961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_sortingLayerID_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_sortingLayerID_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481961, XrefRangeEnd = 481963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_sortingOrder_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_sortingOrder_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static void UpdateAllSortingGroups() => SortingGroup.UpdateAllSortingGroupsDelegateField();

  public unsafe string sortingLayerName
  {
    get
    {
      ManagedSpanWrapper ret;
      string stringAndDispose;
      try
      {
        System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SortingGroup>(this);
        if (_unity_self == System.IntPtr.Zero)
          UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
        SortingGroup.get_sortingLayerName_Injected(_unity_self, out ret);
      }
      finally
      {
        stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
      }
      return stringAndDispose;
    }
    set
    {
      try
      {
        System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SortingGroup>(this);
        if (_unity_self == System.IntPtr.Zero)
          UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
        ManagedSpanWrapper managedSpanWrapper;
        if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
        {
          Il2CppSystem.ReadOnlySpan<char> readOnlySpan = value.AsSpan();
          fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
            managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
        }
        SortingGroup.set_sortingLayerName_Injected(_unity_self, ref managedSpanWrapper);
      }
      finally
      {
        __unpin(begin);
      }
    }
  }

  public bool sortAtRoot
  {
    get
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SortingGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return SortingGroup.get_sortAtRoot_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SortingGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      SortingGroup.set_sortAtRoot_Injected(_unity_self, value);
    }
  }

  public int sortingGroupID
  {
    get
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SortingGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return SortingGroup.get_sortingGroupID_Injected(_unity_self);
    }
  }

  public int sortingGroupOrder
  {
    get
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SortingGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return SortingGroup.get_sortingGroupOrder_Injected(_unity_self);
    }
  }

  public int index
  {
    get
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SortingGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return SortingGroup.get_index_Injected(_unity_self);
    }
  }

  public uint sortingKey
  {
    get
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SortingGroup>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return SortingGroup.get_sortingKey_Injected(_unity_self);
    }
  }

  public static void get_sortingLayerName_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
  {
    SortingGroup.get_sortingLayerName_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void set_sortingLayerName_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
  {
    SortingGroup.set_sortingLayerName_InjectedDelegateField(_unity_self, (System.IntPtr) ref value);
  }

  public static void set_sortingLayerID_Injected(System.IntPtr _unity_self, int value)
  {
    SortingGroup.set_sortingLayerID_InjectedDelegateField(_unity_self, value);
  }

  public static void set_sortingOrder_Injected(System.IntPtr _unity_self, int value)
  {
    SortingGroup.set_sortingOrder_InjectedDelegateField(_unity_self, value);
  }

  public static bool get_sortAtRoot_Injected(System.IntPtr _unity_self)
  {
    return SortingGroup.get_sortAtRoot_InjectedDelegateField(_unity_self);
  }

  public static void set_sortAtRoot_Injected(System.IntPtr _unity_self, bool value)
  {
    SortingGroup.set_sortAtRoot_InjectedDelegateField(_unity_self, value);
  }

  public static int get_sortingGroupID_Injected(System.IntPtr _unity_self)
  {
    return SortingGroup.get_sortingGroupID_InjectedDelegateField(_unity_self);
  }

  public static int get_sortingGroupOrder_Injected(System.IntPtr _unity_self)
  {
    return SortingGroup.get_sortingGroupOrder_InjectedDelegateField(_unity_self);
  }

  public static int get_index_Injected(System.IntPtr _unity_self)
  {
    return SortingGroup.get_index_InjectedDelegateField(_unity_self);
  }

  public static uint get_sortingKey_Injected(System.IntPtr _unity_self)
  {
    return SortingGroup.get_sortingKey_InjectedDelegateField(_unity_self);
  }

  private delegate void UpdateAllSortingGroupsDelegate();

  private delegate void get_sortingLayerName_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void set_sortingLayerName_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

  private delegate void set_sortingLayerID_InjectedDelegate(System.IntPtr _unity_self, int value);

  private delegate void set_sortingOrder_InjectedDelegate(System.IntPtr _unity_self, int value);

  private delegate bool get_sortAtRoot_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_sortAtRoot_InjectedDelegate(System.IntPtr _unity_self, bool value);

  private delegate int get_sortingGroupID_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int get_sortingGroupOrder_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int get_index_InjectedDelegate(System.IntPtr _unity_self);

  private delegate uint get_sortingKey_InjectedDelegate(System.IntPtr _unity_self);
}
