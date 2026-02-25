// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.PlayableOutputHandle
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct PlayableOutputHandle
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Version;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Null;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutputHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayableOutputOfType_Internal_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutputHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Internal_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayableOutputType_Internal_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetReferenceObject_Internal_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetUserData_Internal_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSourcePlayable_Internal_PlayableHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSourcePlayable_Internal_Void_PlayableHandle_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSourceOutputPort_Internal_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetWeight_Internal_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PushNotification_Internal_Void_PlayableHandle_INotification_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotificationReceiver_Internal_Void_INotificationReceiver_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetReferenceObject_Injected_Private_Static_Void_byref_PlayableOutputHandle_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PushNotification_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_INotification_Object_0;
  [FieldOffset(0)]
  public System.IntPtr m_Handle;
  [FieldOffset(8)]
  public uint m_Version;
  private static readonly PlayableOutputHandle.IsNullDelegate IsNullDelegateField;
  private static readonly PlayableOutputHandle.GetWeightDelegate GetWeightDelegateField;
  private static readonly PlayableOutputHandle.GetNotificationReceiversDelegate GetNotificationReceiversDelegateField;
  private static readonly PlayableOutputHandle.RemoveNotificationReceiverDelegate RemoveNotificationReceiverDelegateField;
  private static readonly PlayableOutputHandle.GetReferenceObject_InjectedDelegate GetReferenceObject_InjectedDelegateField;
  private static readonly PlayableOutputHandle.GetUserData_InjectedDelegate GetUserData_InjectedDelegateField;

  static PlayableOutputHandle()
  {
    Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", nameof (PlayableOutputHandle));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr);
    PlayableOutputHandle.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, nameof (m_Handle));
    PlayableOutputHandle.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, nameof (m_Version));
    PlayableOutputHandle.NativeFieldInfoPtr_m_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, nameof (m_Null));
    PlayableOutputHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669529);
    PlayableOutputHandle.NativeMethodInfoPtr_IsPlayableOutputOfType_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669530);
    PlayableOutputHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669531);
    PlayableOutputHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669532);
    PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669533);
    PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669534);
    PlayableOutputHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669535);
    PlayableOutputHandle.NativeMethodInfoPtr_IsValid_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669536);
    PlayableOutputHandle.NativeMethodInfoPtr_GetPlayableOutputType_Internal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669537);
    PlayableOutputHandle.NativeMethodInfoPtr_SetReferenceObject_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669538);
    PlayableOutputHandle.NativeMethodInfoPtr_SetUserData_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669539);
    PlayableOutputHandle.NativeMethodInfoPtr_GetSourcePlayable_Internal_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669540);
    PlayableOutputHandle.NativeMethodInfoPtr_SetSourcePlayable_Internal_Void_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669541);
    PlayableOutputHandle.NativeMethodInfoPtr_GetSourceOutputPort_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669542);
    PlayableOutputHandle.NativeMethodInfoPtr_SetWeight_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669543);
    PlayableOutputHandle.NativeMethodInfoPtr_PushNotification_Internal_Void_PlayableHandle_INotification_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669544);
    PlayableOutputHandle.NativeMethodInfoPtr_AddNotificationReceiver_Internal_Void_INotificationReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669545);
    PlayableOutputHandle.NativeMethodInfoPtr_SetReferenceObject_Injected_Private_Static_Void_byref_PlayableOutputHandle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669547);
    PlayableOutputHandle.NativeMethodInfoPtr_GetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669548);
    PlayableOutputHandle.NativeMethodInfoPtr_SetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669549);
    PlayableOutputHandle.NativeMethodInfoPtr_PushNotification_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_INotification_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100669550);
    PlayableOutputHandle.IsNullDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.IsNullDelegate>("UnityEngine.Playables.PlayableOutputHandle::IsNull");
    PlayableOutputHandle.GetWeightDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetWeightDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetWeight");
    PlayableOutputHandle.GetNotificationReceiversDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetNotificationReceiversDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetNotificationReceivers");
    PlayableOutputHandle.RemoveNotificationReceiverDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.RemoveNotificationReceiverDelegate>("UnityEngine.Playables.PlayableOutputHandle::RemoveNotificationReceiver");
    PlayableOutputHandle.GetReferenceObject_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetReferenceObject_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetReferenceObject_Injected");
    PlayableOutputHandle.GetUserData_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetUserData_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetUserData_Injected");
  }

  public static unsafe PlayableOutputHandle Null
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 481005, RefRangeEnd = 481007, XrefRangeStart = 481001, XrefRangeEnd = 481005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutputHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(PlayableOutputHandle*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 481016, RefRangeEnd = 481027, XrefRangeStart = 481007, XrefRangeEnd = 481016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsPlayableOutputOfType<T>()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.MethodInfoStoreGeneric_IsPlayableOutputOfType_Internal_Boolean_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481027, XrefRangeEnd = 481030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator ==(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481030, XrefRangeEnd = 481038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object p)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481038, XrefRangeEnd = 481041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(PlayableOutputHandle other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutputHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 481043, RefRangeEnd = 481053, XrefRangeStart = 481041, XrefRangeEnd = 481043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsValid()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_IsValid_Internal_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 481055, RefRangeEnd = 481057, XrefRangeStart = 481053, XrefRangeEnd = 481055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppSystem.Type GetPlayableOutputType()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetPlayableOutputType_Internal_Type_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 481065, RefRangeEnd = 481066, XrefRangeStart = 481057, XrefRangeEnd = 481065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetReferenceObject(UnityEngine.Object target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetReferenceObject_Internal_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 481068, RefRangeEnd = 481069, XrefRangeStart = 481066, XrefRangeEnd = 481068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetUserData(UnityEngine.Object target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetUserData_Internal_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 481074, RefRangeEnd = 481075, XrefRangeStart = 481069, XrefRangeEnd = 481074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayableHandle GetSourcePlayable()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetSourcePlayable_Internal_PlayableHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 481080, RefRangeEnd = 481082, XrefRangeStart = 481075, XrefRangeEnd = 481080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSourcePlayable(PlayableHandle target, int port)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetSourcePlayable_Internal_Void_PlayableHandle_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 481084, RefRangeEnd = 481086, XrefRangeStart = 481082, XrefRangeEnd = 481084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetSourceOutputPort()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetSourceOutputPort_Internal_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 481090, RefRangeEnd = 481091, XrefRangeStart = 481086, XrefRangeEnd = 481090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetWeight(float weight)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &weight
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetWeight_Internal_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 481096, RefRangeEnd = 481097, XrefRangeStart = 481091, XrefRangeEnd = 481096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PushNotification(
    PlayableHandle origin,
    INotification notification,
    Il2CppSystem.Object context)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &origin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notification);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_PushNotification_Internal_Void_PlayableHandle_INotification_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 481099, RefRangeEnd = 481101, XrefRangeStart = 481097, XrefRangeEnd = 481099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddNotificationReceiver(INotificationReceiver receiver)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) receiver)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_AddNotificationReceiver_Internal_Void_INotificationReceiver_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481101, XrefRangeEnd = 481103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetReferenceObject_Injected(
    ref PlayableOutputHandle _unity_self,
    System.IntPtr target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetReferenceObject_Injected_Private_Static_Void_byref_PlayableOutputHandle_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481103, XrefRangeEnd = 481105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetSourcePlayable_Injected(
    ref PlayableOutputHandle _unity_self,
    out PlayableHandle ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481105, XrefRangeEnd = 481107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetSourcePlayable_Injected(
    ref PlayableOutputHandle _unity_self,
    [In] ref PlayableHandle target,
    int port)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481107, XrefRangeEnd = 481109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void PushNotification_Injected(
    ref PlayableOutputHandle _unity_self,
    [In] ref PlayableHandle origin,
    INotification notification,
    Il2CppSystem.Object context)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref origin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notification);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_PushNotification_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_INotification_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe PlayableOutputHandle m_Null
  {
    get
    {
      PlayableOutputHandle mNull;
      IL2CPP.il2cpp_field_static_get_value(PlayableOutputHandle.NativeFieldInfoPtr_m_Null, (void*) &mNull);
      return mNull;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlayableOutputHandle.NativeFieldInfoPtr_m_Null, (void*) &value);
    }
  }

  public static bool operator !=(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
  {
    return !PlayableOutputHandle.CompareVersion(lhs, rhs);
  }

  public bool IsNull()
  {
    return PlayableOutputHandle.IsNullDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public UnityEngine.Object GetReferenceObject()
  {
    return Unmarshal.UnmarshalUnityObject<UnityEngine.Object>(PlayableOutputHandle.GetReferenceObject_Injected(ref this));
  }

  public UnityEngine.Object GetUserData()
  {
    return Unmarshal.UnmarshalUnityObject<UnityEngine.Object>(PlayableOutputHandle.GetUserData_Injected(ref this));
  }

  public float GetWeight()
  {
    return PlayableOutputHandle.GetWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public Il2CppReferenceArray<INotificationReceiver> GetNotificationReceivers()
  {
    System.IntPtr num = PlayableOutputHandle.GetNotificationReceiversDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
    return num == System.IntPtr.Zero ? (Il2CppReferenceArray<INotificationReceiver>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<INotificationReceiver>>(num);
  }

  public void RemoveNotificationReceiver(INotificationReceiver receiver)
  {
    PlayableOutputHandle.RemoveNotificationReceiverDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) receiver));
  }

  public static System.IntPtr GetReferenceObject_Injected(ref PlayableOutputHandle _unity_self)
  {
    return PlayableOutputHandle.GetReferenceObject_InjectedDelegateField((System.IntPtr) ref _unity_self);
  }

  public static System.IntPtr GetUserData_Injected(ref PlayableOutputHandle _unity_self)
  {
    return PlayableOutputHandle.GetUserData_InjectedDelegateField((System.IntPtr) ref _unity_self);
  }

  private sealed class MethodInfoStoreGeneric_IsPlayableOutputOfType_Internal_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputHandle.NativeMethodInfoPtr_IsPlayableOutputOfType_Internal_Boolean_0, Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private delegate bool IsNullDelegate(System.IntPtr _param1);

  private delegate float GetWeightDelegate(System.IntPtr _param1);

  private delegate System.IntPtr GetNotificationReceiversDelegate(System.IntPtr _param1);

  private delegate void RemoveNotificationReceiverDelegate(System.IntPtr _param1, System.IntPtr receiver);

  private delegate System.IntPtr GetReferenceObject_InjectedDelegate(System.IntPtr _unity_self);

  private delegate System.IntPtr GetUserData_InjectedDelegate(System.IntPtr _unity_self);
}
