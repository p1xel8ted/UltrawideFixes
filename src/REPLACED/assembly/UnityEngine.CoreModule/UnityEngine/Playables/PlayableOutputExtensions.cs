// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.PlayableOutputExtensions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

#nullable disable
namespace UnityEngine.Playables;

public static class PlayableOutputExtensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_SetReferenceObject_Public_Static_Void_U_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetUserData_Public_Static_Void_U_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSourcePlayable_Public_Static_Playable_U_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSourcePlayable_Public_Static_Void_U_V_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSourcePlayable_Public_Static_Void_U_V_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSourceOutputPort_Public_Static_Int32_U_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetWeight_Public_Static_Void_U_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PushNotification_Public_Static_Void_U_Playable_INotification_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotificationReceiver_Public_Static_Void_U_INotificationReceiver_0;

  static PlayableOutputExtensions()
  {
    Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", nameof (PlayableOutputExtensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr);
    PlayableOutputExtensions.NativeMethodInfoPtr_SetReferenceObject_Public_Static_Void_U_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100669520);
    PlayableOutputExtensions.NativeMethodInfoPtr_SetUserData_Public_Static_Void_U_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100669521);
    PlayableOutputExtensions.NativeMethodInfoPtr_GetSourcePlayable_Public_Static_Playable_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100669522);
    PlayableOutputExtensions.NativeMethodInfoPtr_SetSourcePlayable_Public_Static_Void_U_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100669523);
    PlayableOutputExtensions.NativeMethodInfoPtr_SetSourcePlayable_Public_Static_Void_U_V_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100669524);
    PlayableOutputExtensions.NativeMethodInfoPtr_GetSourceOutputPort_Public_Static_Int32_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100669525);
    PlayableOutputExtensions.NativeMethodInfoPtr_SetWeight_Public_Static_Void_U_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100669526);
    PlayableOutputExtensions.NativeMethodInfoPtr_PushNotification_Public_Static_Void_U_Playable_INotification_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100669527);
    PlayableOutputExtensions.NativeMethodInfoPtr_AddNotificationReceiver_Public_Static_Void_U_INotificationReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100669528);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480908, RefRangeEnd = 480909, XrefRangeStart = 480899, XrefRangeEnd = 480908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetReferenceObject<U>(this U output, UnityEngine.Object value) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) output;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref output;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_SetReferenceObject_Public_Static_Void_U_Object_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480918, RefRangeEnd = 480919, XrefRangeStart = 480909, XrefRangeEnd = 480918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetUserData<U>(this U output, UnityEngine.Object value) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) output;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref output;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_SetUserData_Public_Static_Void_U_Object_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 480926, RefRangeEnd = 480929, XrefRangeStart = 480919, XrefRangeEnd = 480926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Playable GetSourcePlayable<U>(this U output) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) output;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref output;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_GetSourcePlayable_Public_Static_Playable_U_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Playable*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480942, RefRangeEnd = 480944, XrefRangeStart = 480929, XrefRangeEnd = 480942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetSourcePlayable<U, V>(this U output, V value)
    where U : new()
    where V : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) output;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref output;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    V& local3;
    if (!typeof (V).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<V> local4 = (object) value;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local3 = local4 is string ? (V&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (V&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
    }
    else
      local3 = ref value;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local3;
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_SetSourcePlayable_Public_Static_Void_U_V_0<U, V>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480957, RefRangeEnd = 480958, XrefRangeStart = 480944, XrefRangeEnd = 480957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetSourcePlayable<U, V>(this U output, V value, int port)
    where U : new()
    where V : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) output;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref output;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    V& local3;
    if (!typeof (V).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<V> local4 = (object) value;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local3 = local4 is string ? (V&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (V&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
    }
    else
      local3 = ref value;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_SetSourcePlayable_Public_Static_Void_U_V_Int32_0<U, V>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480964, RefRangeEnd = 480966, XrefRangeStart = 480958, XrefRangeEnd = 480964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetSourceOutputPort<U>(this U output) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) output;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref output;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_GetSourceOutputPort_Public_Static_Int32_U_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 480972, RefRangeEnd = 480975, XrefRangeStart = 480966, XrefRangeEnd = 480972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetWeight<U>(this U output, float value) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) output;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref output;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_SetWeight_Public_Static_Void_U_Single_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 480988, RefRangeEnd = 480991, XrefRangeStart = 480975, XrefRangeEnd = 480988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void PushNotification<U>(
    this U output,
    Playable origin,
    INotification notification,
    Il2CppSystem.Object context = null)
    where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) output;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref output;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &origin;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notification);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_PushNotification_Public_Static_Void_U_Playable_INotification_Object_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 481000, RefRangeEnd = 481001, XrefRangeStart = 480991, XrefRangeEnd = 481000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddNotificationReceiver<U>(
    this U output,
    INotificationReceiver receiver)
    where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) output;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref output;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) receiver);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_AddNotificationReceiver_Public_Static_Void_U_INotificationReceiver_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public PlayableOutputExtensions(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static bool IsOutputNull<U>(U output) where U : struct => output.GetHandle().IsNull();

  public static bool IsOutputValid<U>(U output) where U : struct => output.GetHandle().IsValid();

  public static UnityEngine.Object GetReferenceObject<U>(U output) where U : struct
  {
    return output.GetHandle().GetReferenceObject();
  }

  public static UnityEngine.Object GetUserData<U>(U output) where U : struct
  {
    return output.GetHandle().GetUserData();
  }

  public static float GetWeight<U>(U output) where U : struct => output.GetHandle().GetWeight();

  public static Il2CppReferenceArray<INotificationReceiver> GetNotificationReceivers<U>(U output) where U : struct
  {
    return output.GetHandle().GetNotificationReceivers();
  }

  public static void RemoveNotificationReceiver<U>(U output, INotificationReceiver receiver) where U : struct
  {
    output.GetHandle().RemoveNotificationReceiver(receiver);
  }

  public static int GetSourceInputPort<U>(U output) where U : struct
  {
    return output.GetHandle().GetSourceOutputPort();
  }

  public static void SetSourceInputPort<U>(U output, int value) where U : struct
  {
    output.SetSourcePlayable<U, Playable>(output.GetSourcePlayable<U>(), value);
  }

  public static void SetSourceOutputPort<U>(U output, int value) where U : struct
  {
    output.SetSourcePlayable<U, Playable>(output.GetSourcePlayable<U>(), value);
  }

  private sealed class MethodInfoStoreGeneric_SetReferenceObject_Public_Static_Void_U_Object_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_SetReferenceObject_Public_Static_Void_U_Object_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SetUserData_Public_Static_Void_U_Object_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_SetUserData_Public_Static_Void_U_Object_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetSourcePlayable_Public_Static_Playable_U_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_GetSourcePlayable_Public_Static_Playable_U_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SetSourcePlayable_Public_Static_Void_U_V_0<U, V>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_SetSourcePlayable_Public_Static_Void_U_V_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SetSourcePlayable_Public_Static_Void_U_V_Int32_0<U, V>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_SetSourcePlayable_Public_Static_Void_U_V_Int32_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetSourceOutputPort_Public_Static_Int32_U_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_GetSourceOutputPort_Public_Static_Int32_U_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SetWeight_Public_Static_Void_U_Single_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_SetWeight_Public_Static_Void_U_Single_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_PushNotification_Public_Static_Void_U_Playable_INotification_Object_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_PushNotification_Public_Static_Void_U_Playable_INotification_Object_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_AddNotificationReceiver_Public_Static_Void_U_INotificationReceiver_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_AddNotificationReceiver_Public_Static_Void_U_INotificationReceiver_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }
}
