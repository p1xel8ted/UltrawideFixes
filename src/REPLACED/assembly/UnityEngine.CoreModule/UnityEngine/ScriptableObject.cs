// Decompiled with JetBrains decompiler
// Type: UnityEngine.ScriptableObject
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public class ScriptableObject(System.IntPtr pointer) : Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateScriptableObject_Private_Static_Void_ScriptableObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Internal_Static_ScriptableObject_Type_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Injected_Private_Static_IntPtr_Type_Boolean_0;
  private static readonly ScriptableObject.SetDirty_InjectedDelegate SetDirty_InjectedDelegateField;
  private static readonly ScriptableObject.CreateScriptableObjectInstanceFromName_InjectedDelegate CreateScriptableObjectInstanceFromName_InjectedDelegateField;
  private static readonly ScriptableObject.ResetAndApplyDefaultInstances_InjectedDelegate ResetAndApplyDefaultInstances_InjectedDelegateField;

  static ScriptableObject()
  {
    Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ScriptableObject));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr);
    ScriptableObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100668249);
    ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100668250);
    ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100668251);
    ScriptableObject.NativeMethodInfoPtr_CreateScriptableObject_Private_Static_Void_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100668252);
    ScriptableObject.NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Internal_Static_ScriptableObject_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100668253);
    ScriptableObject.NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Injected_Private_Static_IntPtr_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100668254);
    ScriptableObject.SetDirty_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableObject.SetDirty_InjectedDelegate>("UnityEngine.ScriptableObject::SetDirty_Injected");
    ScriptableObject.CreateScriptableObjectInstanceFromName_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableObject.CreateScriptableObjectInstanceFromName_InjectedDelegate>("UnityEngine.ScriptableObject::CreateScriptableObjectInstanceFromName_Injected");
    ScriptableObject.ResetAndApplyDefaultInstances_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableObject.ResetAndApplyDefaultInstances_InjectedDelegate>("UnityEngine.ScriptableObject::ResetAndApplyDefaultInstances_Injected");
  }

  [CallerCount(131)]
  [CachedScanResults(RefRangeStart = 452982, RefRangeEnd = 453113, XrefRangeStart = 452976, XrefRangeEnd = 452982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptableObject()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 453118, RefRangeEnd = 453128, XrefRangeStart = 453113, XrefRangeEnd = 453118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ScriptableObject CreateInstance(Il2CppSystem.Type type)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptableObject) null : Il2CppObjectPool.Get<ScriptableObject>(num3);
  }

  [CallerCount(24)]
  [CachedScanResults(RefRangeStart = 453134, RefRangeEnd = 453158, XrefRangeStart = 453128, XrefRangeEnd = 453134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T CreateInstance<T>() where T : ScriptableObject
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.MethodInfoStoreGeneric_CreateInstance_Public_Static_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453158, XrefRangeEnd = 453160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateScriptableObject(ScriptableObject self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) self)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr_CreateScriptableObject_Private_Static_Void_ScriptableObject_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453160, XrefRangeEnd = 453165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ScriptableObject CreateScriptableObjectInstanceFromType(
    Il2CppSystem.Type type,
    bool applyDefaultsAndReset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &applyDefaultsAndReset;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Internal_Static_ScriptableObject_Type_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptableObject) null : Il2CppObjectPool.Get<ScriptableObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453165, XrefRangeEnd = 453167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr CreateScriptableObjectInstanceFromType_Injected(
    Il2CppSystem.Type type,
    bool applyDefaultsAndReset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &applyDefaultsAndReset;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Injected_Private_Static_IntPtr_Type_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public void SetDirty()
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ScriptableObject>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    ScriptableObject.SetDirty_Injected(_unity_self);
  }

  public static ScriptableObject CreateInstance(string className)
  {
    return ScriptableObject.CreateScriptableObjectInstanceFromName(className);
  }

  public static ScriptableObject CreateInstance(Il2CppSystem.Type type, Il2CppSystem.Action<ScriptableObject> initialize)
  {
    ScriptableObject instance = Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ScriptableObject>()).IsAssignableFrom(type) ? ScriptableObject.CreateScriptableObjectInstanceFromType(type, false) : throw new Il2CppSystem.ArgumentException("Type must inherit ScriptableObject.", nameof (type));
    try
    {
      initialize.Invoke(instance);
    }
    finally
    {
      ScriptableObject.ResetAndApplyDefaultInstances((Object) instance);
    }
    return instance;
  }

  public static unsafe ScriptableObject CreateScriptableObjectInstanceFromName(string className)
  {
    System.IntPtr fromNameInjected;
    ScriptableObject instanceFromName;
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(className, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = className.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      fromNameInjected = ScriptableObject.CreateScriptableObjectInstanceFromName_Injected(ref managedSpanWrapper);
    }
    finally
    {
      instanceFromName = Unmarshal.UnmarshalUnityObject<ScriptableObject>(fromNameInjected);
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
    return instanceFromName;
  }

  public static void ResetAndApplyDefaultInstances(Object obj)
  {
    if ((object) obj == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) obj, nameof (obj));
    System.IntPtr num = Object.MarshalledUnityObject.MarshalNotNull<Object>(obj);
    if (num == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) obj, nameof (obj));
    ScriptableObject.ResetAndApplyDefaultInstances_Injected(num);
  }

  public static void SetDirty_Injected(System.IntPtr _unity_self)
  {
    ScriptableObject.SetDirty_InjectedDelegateField(_unity_self);
  }

  public static System.IntPtr CreateScriptableObjectInstanceFromName_Injected(
    ref ManagedSpanWrapper className)
  {
    return ScriptableObject.CreateScriptableObjectInstanceFromName_InjectedDelegateField((System.IntPtr) ref className);
  }

  public static void ResetAndApplyDefaultInstances_Injected(System.IntPtr obj)
  {
    ScriptableObject.ResetAndApplyDefaultInstances_InjectedDelegateField(obj);
  }

  private sealed class MethodInfoStoreGeneric_CreateInstance_Public_Static_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_T_0, Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private delegate void SetDirty_InjectedDelegate(System.IntPtr _unity_self);

  private delegate System.IntPtr CreateScriptableObjectInstanceFromName_InjectedDelegate(
    System.IntPtr className);

  private delegate void ResetAndApplyDefaultInstances_InjectedDelegate(System.IntPtr obj);
}
