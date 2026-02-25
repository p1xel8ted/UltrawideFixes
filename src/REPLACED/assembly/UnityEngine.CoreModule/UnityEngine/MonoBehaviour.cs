// Decompiled with JetBrains decompiler
// Type: UnityEngine.MonoBehaviour
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Threading;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public class MonoBehaviour(System.IntPtr pointer) : Behaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CancellationTokenSource;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_destroyCancellationToken_Public_get_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RaiseCancellation_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsInvoking_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CancelInvoke_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Void_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeRepeating_Public_Void_String_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CancelInvoke_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsInvoking_Public_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartCoroutine_Auto_Public_Coroutine_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopCoroutine_Public_Void_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopCoroutine_Public_Void_Coroutine_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopCoroutine_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopAllCoroutines_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_useGUILayout_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_useGUILayout_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_didStart_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_didAwake_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_print_Public_Static_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CancelInvokeAll_Private_Static_Void_MonoBehaviour_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_IsInvokingAll_Private_Static_Boolean_MonoBehaviour_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeDelayed_Private_Static_Void_MonoBehaviour_String_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CancelInvoke_Private_Static_Void_MonoBehaviour_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsInvoking_Private_Static_Boolean_MonoBehaviour_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsObjectMonoBehaviour_Private_Static_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartCoroutineManaged_Private_Coroutine_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartCoroutineManaged2_Private_Coroutine_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopCoroutineManaged_Private_Void_Coroutine_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopCoroutineFromEnumeratorManaged_Private_Void_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetScriptClassName_Internal_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCancellationTokenCreated_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopCoroutine_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopAllCoroutines_Injected_Private_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_useGUILayout_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_useGUILayout_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_didStart_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_didAwake_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CancelInvokeAll_Injected_Private_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_IsInvokingAll_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeDelayed_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CancelInvoke_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsInvoking_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsObjectMonoBehaviour_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartCoroutineManaged_Injected_Private_Static_Coroutine_IntPtr_byref_ManagedSpanWrapper_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartCoroutineManaged2_Injected_Private_Static_Coroutine_IntPtr_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopCoroutineManaged_Injected_Private_Static_Void_IntPtr_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopCoroutineFromEnumeratorManaged_Injected_Private_Static_Void_IntPtr_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetScriptClassName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCancellationTokenCreated_Injected_Private_Static_Void_IntPtr_0;

  static MonoBehaviour()
  {
    Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (MonoBehaviour));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr);
    MonoBehaviour.NativeFieldInfoPtr_m_CancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, nameof (m_CancellationTokenSource));
    MonoBehaviour.NativeMethodInfoPtr_get_destroyCancellationToken_Public_get_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668186);
    MonoBehaviour.NativeMethodInfoPtr_RaiseCancellation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668187);
    MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668188);
    MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668189);
    MonoBehaviour.NativeMethodInfoPtr_Invoke_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668190);
    MonoBehaviour.NativeMethodInfoPtr_InvokeRepeating_Public_Void_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668191);
    MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668192);
    MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668193);
    MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668194);
    MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668195);
    MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668196);
    MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Auto_Public_Coroutine_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668197);
    MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Public_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668198);
    MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Public_Void_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668199);
    MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668200);
    MonoBehaviour.NativeMethodInfoPtr_StopAllCoroutines_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668201);
    MonoBehaviour.NativeMethodInfoPtr_get_useGUILayout_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668202);
    MonoBehaviour.NativeMethodInfoPtr_set_useGUILayout_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668203);
    MonoBehaviour.NativeMethodInfoPtr_get_didStart_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668204);
    MonoBehaviour.NativeMethodInfoPtr_get_didAwake_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668205);
    MonoBehaviour.NativeMethodInfoPtr_print_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668206);
    MonoBehaviour.NativeMethodInfoPtr_Internal_CancelInvokeAll_Private_Static_Void_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668207);
    MonoBehaviour.NativeMethodInfoPtr_Internal_IsInvokingAll_Private_Static_Boolean_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668208);
    MonoBehaviour.NativeMethodInfoPtr_InvokeDelayed_Private_Static_Void_MonoBehaviour_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668209);
    MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Private_Static_Void_MonoBehaviour_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668210);
    MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Private_Static_Boolean_MonoBehaviour_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668211);
    MonoBehaviour.NativeMethodInfoPtr_IsObjectMonoBehaviour_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668212);
    MonoBehaviour.NativeMethodInfoPtr_StartCoroutineManaged_Private_Coroutine_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668213);
    MonoBehaviour.NativeMethodInfoPtr_StartCoroutineManaged2_Private_Coroutine_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668214);
    MonoBehaviour.NativeMethodInfoPtr_StopCoroutineManaged_Private_Void_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668215);
    MonoBehaviour.NativeMethodInfoPtr_StopCoroutineFromEnumeratorManaged_Private_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668216);
    MonoBehaviour.NativeMethodInfoPtr_GetScriptClassName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668217);
    MonoBehaviour.NativeMethodInfoPtr_OnCancellationTokenCreated_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668218);
    MonoBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668219);
    MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668220);
    MonoBehaviour.NativeMethodInfoPtr_StopAllCoroutines_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668221);
    MonoBehaviour.NativeMethodInfoPtr_get_useGUILayout_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668222);
    MonoBehaviour.NativeMethodInfoPtr_set_useGUILayout_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668223);
    MonoBehaviour.NativeMethodInfoPtr_get_didStart_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668224);
    MonoBehaviour.NativeMethodInfoPtr_get_didAwake_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668225);
    MonoBehaviour.NativeMethodInfoPtr_Internal_CancelInvokeAll_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668226);
    MonoBehaviour.NativeMethodInfoPtr_Internal_IsInvokingAll_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668227);
    MonoBehaviour.NativeMethodInfoPtr_InvokeDelayed_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668228);
    MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668229);
    MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668230);
    MonoBehaviour.NativeMethodInfoPtr_IsObjectMonoBehaviour_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668231);
    MonoBehaviour.NativeMethodInfoPtr_StartCoroutineManaged_Injected_Private_Static_Coroutine_IntPtr_byref_ManagedSpanWrapper_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668232);
    MonoBehaviour.NativeMethodInfoPtr_StartCoroutineManaged2_Injected_Private_Static_Coroutine_IntPtr_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668233);
    MonoBehaviour.NativeMethodInfoPtr_StopCoroutineManaged_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668234);
    MonoBehaviour.NativeMethodInfoPtr_StopCoroutineFromEnumeratorManaged_Injected_Private_Static_Void_IntPtr_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668235);
    MonoBehaviour.NativeMethodInfoPtr_GetScriptClassName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668236);
    MonoBehaviour.NativeMethodInfoPtr_OnCancellationTokenCreated_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100668237);
  }

  public unsafe CancellationToken destroyCancellationToken
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 452113, RefRangeEnd = 452115, XrefRangeStart = 452088, XrefRangeEnd = 452113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_get_destroyCancellationToken_Public_get_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new CancellationToken(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452115, XrefRangeEnd = 452116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RaiseCancellation()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_RaiseCancellation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452116, XrefRangeEnd = 452125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsInvoking()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452125, XrefRangeEnd = 452134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CancelInvoke()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452134, XrefRangeEnd = 452135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Invoke(string methodName, float time)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(methodName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_Invoke_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452135, XrefRangeEnd = 452142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InvokeRepeating(string methodName, float time, float repeatRate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(methodName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &repeatRate;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_InvokeRepeating_Public_Void_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452142, XrefRangeEnd = 452143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CancelInvoke(string methodName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(methodName)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452143, XrefRangeEnd = 452144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsInvoking(string methodName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(methodName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 452167, RefRangeEnd = 452170, XrefRangeStart = 452144, XrefRangeEnd = 452167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Coroutine StartCoroutine(string methodName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(methodName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Coroutine) null : Il2CppObjectPool.Get<Coroutine>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452170, XrefRangeEnd = 452193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Coroutine StartCoroutine(string methodName, Il2CppSystem.Object value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(methodName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Coroutine) null : Il2CppObjectPool.Get<Coroutine>(num3);
  }

  [CallerCount(250)]
  [CachedScanResults(RefRangeStart = 452218, RefRangeEnd = 452468, XrefRangeStart = 452193, XrefRangeEnd = 452218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Coroutine StartCoroutine(IEnumerator routine)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) routine)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Coroutine) null : Il2CppObjectPool.Get<Coroutine>(num3);
  }

  [CallerCount(250)]
  [CachedScanResults(RefRangeStart = 452218, RefRangeEnd = 452468, XrefRangeStart = 452218, XrefRangeEnd = 452468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Coroutine StartCoroutine_Auto(IEnumerator routine)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) routine)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Auto_Public_Coroutine_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Coroutine) null : Il2CppObjectPool.Get<Coroutine>(num3);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 452493, RefRangeEnd = 452507, XrefRangeStart = 452468, XrefRangeEnd = 452493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopCoroutine(IEnumerator routine)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) routine)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Public_Void_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(22)]
  [CachedScanResults(RefRangeStart = 452532, RefRangeEnd = 452554, XrefRangeStart = 452507, XrefRangeEnd = 452532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopCoroutine(Coroutine routine)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) routine)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Public_Void_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 452570, RefRangeEnd = 452572, XrefRangeStart = 452554, XrefRangeEnd = 452570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopCoroutine(string methodName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(methodName)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(118)]
  [CachedScanResults(RefRangeStart = 452577, RefRangeEnd = 452695, XrefRangeStart = 452572, XrefRangeEnd = 452577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopAllCoroutines()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopAllCoroutines_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool useGUILayout
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452695, XrefRangeEnd = 452700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_get_useGUILayout_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452700, XrefRangeEnd = 452705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_set_useGUILayout_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool didStart
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452705, XrefRangeEnd = 452710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_get_didStart_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool didAwake
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452710, XrefRangeEnd = 452715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_get_didAwake_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 452719, RefRangeEnd = 452722, XrefRangeStart = 452715, XrefRangeEnd = 452719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void print(Il2CppSystem.Object message)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) message)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_print_Public_Static_Void_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_CancelInvokeAll(MonoBehaviour self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) self)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_Internal_CancelInvokeAll_Private_Static_Void_MonoBehaviour_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Internal_IsInvokingAll(MonoBehaviour self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) self)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_Internal_IsInvokingAll_Private_Static_Boolean_MonoBehaviour_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 452742, RefRangeEnd = 452744, XrefRangeStart = 452722, XrefRangeEnd = 452742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeDelayed(
    MonoBehaviour self,
    string methodName,
    float time,
    float repeatRate)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) self);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &repeatRate;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_InvokeDelayed_Private_Static_Void_MonoBehaviour_String_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 452764, RefRangeEnd = 452765, XrefRangeStart = 452744, XrefRangeEnd = 452764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CancelInvoke(MonoBehaviour self, string methodName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) self);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Private_Static_Void_MonoBehaviour_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 452785, RefRangeEnd = 452786, XrefRangeStart = 452765, XrefRangeEnd = 452785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsInvoking(MonoBehaviour self, string methodName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) self);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Private_Static_Boolean_MonoBehaviour_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452786, XrefRangeEnd = 452795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsObjectMonoBehaviour(Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_IsObjectMonoBehaviour_Private_Static_Boolean_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 452811, RefRangeEnd = 452813, XrefRangeStart = 452795, XrefRangeEnd = 452811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Coroutine StartCoroutineManaged(string methodName, Il2CppSystem.Object value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(methodName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutineManaged_Private_Coroutine_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Coroutine) null : Il2CppObjectPool.Get<Coroutine>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452813, XrefRangeEnd = 452818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Coroutine StartCoroutineManaged2(IEnumerator enumerator)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enumerator)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutineManaged2_Private_Coroutine_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Coroutine) null : Il2CppObjectPool.Get<Coroutine>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452818, XrefRangeEnd = 452823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopCoroutineManaged(Coroutine routine)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) routine)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopCoroutineManaged_Private_Void_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452823, XrefRangeEnd = 452828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopCoroutineFromEnumeratorManaged(IEnumerator routine)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) routine)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopCoroutineFromEnumeratorManaged_Private_Void_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452828, XrefRangeEnd = 452835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetScriptClassName()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_GetScriptClassName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452835, XrefRangeEnd = 452840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCancellationTokenCreated()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_OnCancellationTokenCreated_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(753)]
  [CachedScanResults(RefRangeStart = 443820, RefRangeEnd = 444573, XrefRangeStart = 443820, XrefRangeEnd = 444573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MonoBehaviour()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452840, XrefRangeEnd = 452842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void StopCoroutine_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper methodName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref methodName;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452842, XrefRangeEnd = 452844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void StopAllCoroutines_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopAllCoroutines_Injected_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452844, XrefRangeEnd = 452846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_useGUILayout_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_get_useGUILayout_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452846, XrefRangeEnd = 452848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_useGUILayout_Injected(System.IntPtr _unity_self, bool value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_set_useGUILayout_Injected_Private_Static_Void_IntPtr_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452848, XrefRangeEnd = 452850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_didStart_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_get_didStart_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452850, XrefRangeEnd = 452852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_didAwake_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_get_didAwake_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452852, XrefRangeEnd = 452854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_CancelInvokeAll_Injected(System.IntPtr self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &self
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_Internal_CancelInvokeAll_Injected_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452854, XrefRangeEnd = 452856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Internal_IsInvokingAll_Injected(System.IntPtr self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_Internal_IsInvokingAll_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452856, XrefRangeEnd = 452858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeDelayed_Injected(
    System.IntPtr self,
    ref ManagedSpanWrapper methodName,
    float time,
    float repeatRate)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref methodName;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &repeatRate;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_InvokeDelayed_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452858, XrefRangeEnd = 452860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CancelInvoke_Injected(System.IntPtr self, ref ManagedSpanWrapper methodName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref methodName;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452860, XrefRangeEnd = 452862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsInvoking_Injected(System.IntPtr self, ref ManagedSpanWrapper methodName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref methodName;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452862, XrefRangeEnd = 452864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsObjectMonoBehaviour_Injected(System.IntPtr obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &obj
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_IsObjectMonoBehaviour_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452864, XrefRangeEnd = 452866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Coroutine StartCoroutineManaged_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper methodName,
    Il2CppSystem.Object value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref methodName;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutineManaged_Injected_Private_Static_Coroutine_IntPtr_byref_ManagedSpanWrapper_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Coroutine) null : Il2CppObjectPool.Get<Coroutine>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452866, XrefRangeEnd = 452868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Coroutine StartCoroutineManaged2_Injected(
    System.IntPtr _unity_self,
    IEnumerator enumerator)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enumerator);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutineManaged2_Injected_Private_Static_Coroutine_IntPtr_IEnumerator_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Coroutine) null : Il2CppObjectPool.Get<Coroutine>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452868, XrefRangeEnd = 452870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void StopCoroutineManaged_Injected(System.IntPtr _unity_self, System.IntPtr routine)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &routine;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopCoroutineManaged_Injected_Private_Static_Void_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452870, XrefRangeEnd = 452872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void StopCoroutineFromEnumeratorManaged_Injected(
    System.IntPtr _unity_self,
    IEnumerator routine)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) routine);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopCoroutineFromEnumeratorManaged_Injected_Private_Static_Void_IntPtr_IEnumerator_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452872, XrefRangeEnd = 452874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetScriptClassName_Injected(
    System.IntPtr _unity_self,
    out ManagedSpanWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_GetScriptClassName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452874, XrefRangeEnd = 452876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnCancellationTokenCreated_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_OnCancellationTokenCreated_Injected_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CancellationTokenSource m_CancellationTokenSource
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MonoBehaviour.NativeFieldInfoPtr_m_CancellationTokenSource));
      return num == System.IntPtr.Zero ? (CancellationTokenSource) null : Il2CppObjectPool.Get<CancellationTokenSource>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MonoBehaviour.NativeFieldInfoPtr_m_CancellationTokenSource), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
