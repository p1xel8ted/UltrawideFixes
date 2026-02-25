// Decompiled with JetBrains decompiler
// Type: UnityEngine.CullingGroup
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public class CullingGroup(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OnStateChanged;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendEvents_Private_Static_Void_CullingGroup_IntPtr_Int32_0;
  private static readonly CullingGroup.InitDelegate InitDelegateField;
  private static readonly CullingGroup.DisposeInternal_InjectedDelegate DisposeInternal_InjectedDelegateField;
  private static readonly CullingGroup.get_enabled_InjectedDelegate get_enabled_InjectedDelegateField;
  private static readonly CullingGroup.set_enabled_InjectedDelegate set_enabled_InjectedDelegateField;
  private static readonly CullingGroup.get_targetCamera_InjectedDelegate get_targetCamera_InjectedDelegateField;
  private static readonly CullingGroup.set_targetCamera_InjectedDelegate set_targetCamera_InjectedDelegateField;
  private static readonly CullingGroup.SetBoundingSpheres_InjectedDelegate SetBoundingSpheres_InjectedDelegateField;
  private static readonly CullingGroup.SetBoundingSphereCount_InjectedDelegate SetBoundingSphereCount_InjectedDelegateField;
  private static readonly CullingGroup.EraseSwapBack_InjectedDelegate EraseSwapBack_InjectedDelegateField;
  private static readonly CullingGroup.QueryIndices_InjectedDelegate QueryIndices_InjectedDelegateField;
  private static readonly CullingGroup.IsVisible_InjectedDelegate IsVisible_InjectedDelegateField;
  private static readonly CullingGroup.GetDistance_InjectedDelegate GetDistance_InjectedDelegateField;
  private static readonly CullingGroup.SetBoundingDistances_InjectedDelegate SetBoundingDistances_InjectedDelegateField;
  private static readonly CullingGroup.SetDistanceReferencePoint_InternalVector3_InjectedDelegate SetDistanceReferencePoint_InternalVector3_InjectedDelegateField;
  private static readonly CullingGroup.SetDistanceReferencePoint_InternalTransform_InjectedDelegate SetDistanceReferencePoint_InternalTransform_InjectedDelegateField;
  private static readonly CullingGroup.FinalizerFailure_InjectedDelegate FinalizerFailure_InjectedDelegateField;

  static CullingGroup()
  {
    Il2CppClassPointerStore<CullingGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (CullingGroup));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr);
    CullingGroup.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, nameof (m_Ptr));
    CullingGroup.NativeFieldInfoPtr_m_OnStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, nameof (m_OnStateChanged));
    CullingGroup.NativeMethodInfoPtr_SendEvents_Private_Static_Void_CullingGroup_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664358);
    CullingGroup.InitDelegateField = IL2CPP.ResolveICall<CullingGroup.InitDelegate>("UnityEngine.CullingGroup::Init");
    CullingGroup.DisposeInternal_InjectedDelegateField = IL2CPP.ResolveICall<CullingGroup.DisposeInternal_InjectedDelegate>("UnityEngine.CullingGroup::DisposeInternal_Injected");
    CullingGroup.get_enabled_InjectedDelegateField = IL2CPP.ResolveICall<CullingGroup.get_enabled_InjectedDelegate>("UnityEngine.CullingGroup::get_enabled_Injected");
    CullingGroup.set_enabled_InjectedDelegateField = IL2CPP.ResolveICall<CullingGroup.set_enabled_InjectedDelegate>("UnityEngine.CullingGroup::set_enabled_Injected");
    CullingGroup.get_targetCamera_InjectedDelegateField = IL2CPP.ResolveICall<CullingGroup.get_targetCamera_InjectedDelegate>("UnityEngine.CullingGroup::get_targetCamera_Injected");
    CullingGroup.set_targetCamera_InjectedDelegateField = IL2CPP.ResolveICall<CullingGroup.set_targetCamera_InjectedDelegate>("UnityEngine.CullingGroup::set_targetCamera_Injected");
    CullingGroup.SetBoundingSpheres_InjectedDelegateField = IL2CPP.ResolveICall<CullingGroup.SetBoundingSpheres_InjectedDelegate>("UnityEngine.CullingGroup::SetBoundingSpheres_Injected");
    CullingGroup.SetBoundingSphereCount_InjectedDelegateField = IL2CPP.ResolveICall<CullingGroup.SetBoundingSphereCount_InjectedDelegate>("UnityEngine.CullingGroup::SetBoundingSphereCount_Injected");
    CullingGroup.EraseSwapBack_InjectedDelegateField = IL2CPP.ResolveICall<CullingGroup.EraseSwapBack_InjectedDelegate>("UnityEngine.CullingGroup::EraseSwapBack_Injected");
    CullingGroup.QueryIndices_InjectedDelegateField = IL2CPP.ResolveICall<CullingGroup.QueryIndices_InjectedDelegate>("UnityEngine.CullingGroup::QueryIndices_Injected");
    CullingGroup.IsVisible_InjectedDelegateField = IL2CPP.ResolveICall<CullingGroup.IsVisible_InjectedDelegate>("UnityEngine.CullingGroup::IsVisible_Injected");
    CullingGroup.GetDistance_InjectedDelegateField = IL2CPP.ResolveICall<CullingGroup.GetDistance_InjectedDelegate>("UnityEngine.CullingGroup::GetDistance_Injected");
    CullingGroup.SetBoundingDistances_InjectedDelegateField = IL2CPP.ResolveICall<CullingGroup.SetBoundingDistances_InjectedDelegate>("UnityEngine.CullingGroup::SetBoundingDistances_Injected");
    CullingGroup.SetDistanceReferencePoint_InternalVector3_InjectedDelegateField = IL2CPP.ResolveICall<CullingGroup.SetDistanceReferencePoint_InternalVector3_InjectedDelegate>("UnityEngine.CullingGroup::SetDistanceReferencePoint_InternalVector3_Injected");
    CullingGroup.SetDistanceReferencePoint_InternalTransform_InjectedDelegateField = IL2CPP.ResolveICall<CullingGroup.SetDistanceReferencePoint_InternalTransform_InjectedDelegate>("UnityEngine.CullingGroup::SetDistanceReferencePoint_InternalTransform_Injected");
    CullingGroup.FinalizerFailure_InjectedDelegateField = IL2CPP.ResolveICall<CullingGroup.FinalizerFailure_InjectedDelegate>("UnityEngine.CullingGroup::FinalizerFailure_Injected");
  }

  [CallerCount(0)]
  public static unsafe void SendEvents(CullingGroup cullingGroup, System.IntPtr eventsPtr, int count)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cullingGroup);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &eventsPtr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_SendEvents_Private_Static_Void_CullingGroup_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr m_Ptr
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_Ptr));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_Ptr)) = value;
    }
  }

  public unsafe CullingGroup.StateChanged m_OnStateChanged
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_OnStateChanged));
      return num == System.IntPtr.Zero ? (CullingGroup.StateChanged) null : Il2CppObjectPool.Get<CullingGroup.StateChanged>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_OnStateChanged), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public new virtual void Finalize()
  {
    try
    {
      if (!(this.m_Ptr != Il2CppSystem.IntPtr.Zero))
        return;
      this.FinalizerFailure();
    }
    finally
    {
      base.Finalize();
    }
  }

  public void DisposeInternal()
  {
    System.IntPtr native = CullingGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    CullingGroup.DisposeInternal_Injected(native);
  }

  public void Dispose()
  {
    this.DisposeInternal();
    this.m_Ptr = Il2CppSystem.IntPtr.Zero;
  }

  public CullingGroup.StateChanged onStateChanged
  {
    get => this.m_OnStateChanged;
    set => this.m_OnStateChanged = value;
  }

  public bool enabled
  {
    get
    {
      System.IntPtr native = CullingGroup.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return CullingGroup.get_enabled_Injected(native);
    }
    set
    {
      System.IntPtr native = CullingGroup.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      CullingGroup.set_enabled_Injected(native, value);
    }
  }

  public Camera targetCamera
  {
    get
    {
      System.IntPtr native = CullingGroup.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Unmarshal.UnmarshalUnityObject<Camera>(CullingGroup.get_targetCamera_Injected(native));
    }
    set
    {
      System.IntPtr native = CullingGroup.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      CullingGroup.set_targetCamera_Injected(native, Object.MarshalledUnityObject.Marshal<Camera>(value));
    }
  }

  public void SetBoundingSpheres(Il2CppStructArray<BoundingSphere> array)
  {
    System.IntPtr native = CullingGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    CullingGroup.SetBoundingSpheres_Injected(native, array);
  }

  public void SetBoundingSphereCount(int count)
  {
    System.IntPtr native = CullingGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    CullingGroup.SetBoundingSphereCount_Injected(native, count);
  }

  public void EraseSwapBack(int index)
  {
    System.IntPtr native = CullingGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    CullingGroup.EraseSwapBack_Injected(native, index);
  }

  public static void EraseSwapBack<T>(int index, Il2CppArrayBase<T> myArray, ref int size)
  {
    --size;
    myArray[index] = myArray[size];
  }

  public int QueryIndices(bool visible, Il2CppStructArray<int> result, int firstIndex)
  {
    return this.QueryIndices(visible, -1, CullingQueryOptions.IgnoreDistance, result, firstIndex);
  }

  public int QueryIndices(int distanceIndex, Il2CppStructArray<int> result, int firstIndex)
  {
    return this.QueryIndices(false, distanceIndex, CullingQueryOptions.IgnoreVisibility, result, firstIndex);
  }

  public int QueryIndices(
    bool visible,
    int distanceIndex,
    Il2CppStructArray<int> result,
    int firstIndex)
  {
    return this.QueryIndices(visible, distanceIndex, CullingQueryOptions.Normal, result, firstIndex);
  }

  public unsafe int QueryIndices(
    bool visible,
    int distanceIndex,
    CullingQueryOptions options,
    Il2CppStructArray<int> result,
    int firstIndex)
  {
    System.IntPtr native = CullingGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int num1 = visible ? 1 : 0;
    int distanceIndex1 = distanceIndex;
    int options1 = (int) options;
    Il2CppSystem.Span<int> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<int>) ref span).\u002Ector((Il2CppArrayBase<int>) result);
    int num2;
    fixed (int* begin = &((Il2CppSystem.Span<int>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<int>) ref span).Length);
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      int firstIndex1 = firstIndex;
      num2 = CullingGroup.QueryIndices_Injected(native, num1 != 0, distanceIndex1, (CullingQueryOptions) options1, ref local, firstIndex1);
    }
    return num2;
  }

  public bool IsVisible(int index)
  {
    System.IntPtr native = CullingGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return CullingGroup.IsVisible_Injected(native, index);
  }

  public int GetDistance(int index)
  {
    System.IntPtr native = CullingGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return CullingGroup.GetDistance_Injected(native, index);
  }

  public unsafe void SetBoundingDistances(Il2CppStructArray<float> distances)
  {
    System.IntPtr native = CullingGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Il2CppSystem.Span<float> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<float>) ref span).\u002Ector((Il2CppArrayBase<float>) distances);
    fixed (float* begin = &((Il2CppSystem.Span<float>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper distances1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<float>) ref span).Length);
      CullingGroup.SetBoundingDistances_Injected(native, ref distances1);
    }
  }

  public void SetDistanceReferencePoint_InternalVector3(Vector3 point)
  {
    System.IntPtr native = CullingGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    CullingGroup.SetDistanceReferencePoint_InternalVector3_Injected(native, ref point);
  }

  public void SetDistanceReferencePoint_InternalTransform(Transform transform)
  {
    System.IntPtr native = CullingGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    CullingGroup.SetDistanceReferencePoint_InternalTransform_Injected(native, Object.MarshalledUnityObject.Marshal<Transform>(transform));
  }

  public void SetDistanceReferencePoint(Vector3 point)
  {
    this.SetDistanceReferencePoint_InternalVector3(point);
  }

  public void SetDistanceReferencePoint(Transform transform)
  {
    this.SetDistanceReferencePoint_InternalTransform(transform);
  }

  public static System.IntPtr Init(Il2CppSystem.Object scripting)
  {
    return CullingGroup.InitDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) scripting));
  }

  public void FinalizerFailure()
  {
    System.IntPtr native = CullingGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    CullingGroup.FinalizerFailure_Injected(native);
  }

  public static void DisposeInternal_Injected(System.IntPtr _unity_self)
  {
    CullingGroup.DisposeInternal_InjectedDelegateField(_unity_self);
  }

  public static bool get_enabled_Injected(System.IntPtr _unity_self)
  {
    return CullingGroup.get_enabled_InjectedDelegateField(_unity_self);
  }

  public static void set_enabled_Injected(System.IntPtr _unity_self, bool value)
  {
    CullingGroup.set_enabled_InjectedDelegateField(_unity_self, value);
  }

  public static System.IntPtr get_targetCamera_Injected(System.IntPtr _unity_self)
  {
    return CullingGroup.get_targetCamera_InjectedDelegateField(_unity_self);
  }

  public static void set_targetCamera_Injected(System.IntPtr _unity_self, System.IntPtr value)
  {
    CullingGroup.set_targetCamera_InjectedDelegateField(_unity_self, value);
  }

  public static void SetBoundingSpheres_Injected(
    System.IntPtr _unity_self,
    Il2CppStructArray<BoundingSphere> array)
  {
    CullingGroup.SetBoundingSpheres_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) array));
  }

  public static void SetBoundingSphereCount_Injected(System.IntPtr _unity_self, int count)
  {
    CullingGroup.SetBoundingSphereCount_InjectedDelegateField(_unity_self, count);
  }

  public static void EraseSwapBack_Injected(System.IntPtr _unity_self, int index)
  {
    CullingGroup.EraseSwapBack_InjectedDelegateField(_unity_self, index);
  }

  public static int QueryIndices_Injected(
    System.IntPtr _unity_self,
    bool visible,
    int distanceIndex,
    CullingQueryOptions options,
    ref ManagedSpanWrapper result,
    int firstIndex)
  {
    return CullingGroup.QueryIndices_InjectedDelegateField(_unity_self, visible, distanceIndex, options, (System.IntPtr) ref result, firstIndex);
  }

  public static bool IsVisible_Injected(System.IntPtr _unity_self, int index)
  {
    return CullingGroup.IsVisible_InjectedDelegateField(_unity_self, index);
  }

  public static int GetDistance_Injected(System.IntPtr _unity_self, int index)
  {
    return CullingGroup.GetDistance_InjectedDelegateField(_unity_self, index);
  }

  public static void SetBoundingDistances_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper distances)
  {
    CullingGroup.SetBoundingDistances_InjectedDelegateField(_unity_self, (System.IntPtr) ref distances);
  }

  public static void SetDistanceReferencePoint_InternalVector3_Injected(
    System.IntPtr _unity_self,
    [In] ref Vector3 point)
  {
    CullingGroup.SetDistanceReferencePoint_InternalVector3_InjectedDelegateField(_unity_self, (System.IntPtr) ref point);
  }

  public static void SetDistanceReferencePoint_InternalTransform_Injected(
    System.IntPtr _unity_self,
    System.IntPtr transform)
  {
    CullingGroup.SetDistanceReferencePoint_InternalTransform_InjectedDelegateField(_unity_self, transform);
  }

  public static void FinalizerFailure_Injected(System.IntPtr _unity_self)
  {
    CullingGroup.FinalizerFailure_InjectedDelegateField(_unity_self);
  }

  public sealed class StateChanged(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CullingGroupEvent_0;

    static StateChanged()
    {
      Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, nameof (StateChanged));
      CullingGroup.StateChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr, 100664359);
      CullingGroup.StateChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CullingGroupEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr, 100664360);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 419638, RefRangeEnd = 419651, XrefRangeStart = 419636, XrefRangeEnd = 419638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StateChanged(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CullingGroup.StateChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(CullingGroupEvent sphere)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &sphere
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CullingGroup.StateChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CullingGroupEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator CullingGroup.StateChanged([In] System.Action<CullingGroupEvent> obj0)
    {
      return DelegateSupport.ConvertDelegate<CullingGroup.StateChanged>((System.Delegate) obj0);
    }

    public static CullingGroup.StateChanged operator +(
      [In] CullingGroup.StateChanged obj0,
      [In] CullingGroup.StateChanged obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<CullingGroup.StateChanged>();
    }

    public static CullingGroup.StateChanged operator -(
      [In] CullingGroup.StateChanged obj0,
      [In] CullingGroup.StateChanged obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (CullingGroup.StateChanged) @delegate : @delegate.Cast<CullingGroup.StateChanged>();
    }
  }

  public static class BindingsMarshaller
  {
  }

  private delegate System.IntPtr InitDelegate(System.IntPtr scripting);

  private delegate void DisposeInternal_InjectedDelegate(System.IntPtr _unity_self);

  private delegate bool get_enabled_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_enabled_InjectedDelegate(System.IntPtr _unity_self, bool value);

  private delegate System.IntPtr get_targetCamera_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_targetCamera_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

  private delegate void SetBoundingSpheres_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr array);

  private delegate void SetBoundingSphereCount_InjectedDelegate(System.IntPtr _unity_self, int count);

  private delegate void EraseSwapBack_InjectedDelegate(System.IntPtr _unity_self, int index);

  private delegate int QueryIndices_InjectedDelegate(
    System.IntPtr _unity_self,
    bool visible,
    int distanceIndex,
    CullingQueryOptions options,
    System.IntPtr result,
    int firstIndex);

  private delegate bool IsVisible_InjectedDelegate(System.IntPtr _unity_self, int index);

  private delegate int GetDistance_InjectedDelegate(System.IntPtr _unity_self, int index);

  private delegate void SetBoundingDistances_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr distances);

  private delegate void SetDistanceReferencePoint_InternalVector3_InjectedDelegate(
    System.IntPtr _unity_self,
    [In] System.IntPtr point);

  private delegate void SetDistanceReferencePoint_InternalTransform_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr transform);

  private delegate void FinalizerFailure_InjectedDelegate(System.IntPtr _unity_self);
}
