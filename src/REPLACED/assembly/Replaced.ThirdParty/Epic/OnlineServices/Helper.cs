// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Helper
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices;

public static class Helper : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Allocations;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Callbacks;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_StaticCallbacks;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAllocationCount_Public_Static_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Il2CppArrayBase_1_T_byref_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_TSource_byref_TTarget_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Int32_byref_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Boolean_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Int64_byref_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_UInt32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGetHandle_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_THandle_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Il2CppArrayBase_1_TSource_byref_Il2CppArrayBase_1_TTarget_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_TTarget_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_TTarget_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Nullable_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Il2CppStructArray_1_Byte_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_T_byref_T_TEnum_TEnum_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_ISettable_byref_TTarget_TEnum_TEnum_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Int32_byref_Nullable_1_Boolean_TEnum_TEnum_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_T_byref_Nullable_1_T_TEnum_TEnum_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_T_TEnum_TEnum_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Nullable_1_IntPtr_TEnum_TEnum_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_String_TEnum_TEnum_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_TPublic_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_TCallbackInfo_byref_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_T_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_TTarget_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Handle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Nullable_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_byref_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_byref_UInt32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_byref_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_Int64_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_Il2CppStructArray_1_Byte_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_T_T_byref_TEnum_TEnum_IDisposable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_TTarget_ISettable_byref_TEnum_TEnum_IDisposable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_T_Nullable_1_T_byref_TEnum_TEnum_IDisposable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Handle_byref_TEnum_TEnum_IDisposable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_String_byref_TEnum_TEnum_IDisposable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_Int32_Nullable_1_Boolean_byref_TEnum_TEnum_IDisposable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_TPublic_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_UInt32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalCopy_Internal_Static_Boolean_IntPtr_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalAllocate_Internal_Static_Boolean_byref_IntPtr_Int32_byref_Allocation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalAllocate_Internal_Static_Boolean_byref_IntPtr_UInt32_byref_Allocation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalAllocate_Internal_Static_Boolean_byref_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalAllocate_Internal_Static_Boolean_byref_IntPtr_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalDispose_Internal_Static_Boolean_byref_TDisposable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalDispose_Internal_Static_Boolean_byref_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalDispose_Internal_Static_Boolean_byref_IntPtr_TEnum_TEnum_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDefault_Internal_Static_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddCallback_Internal_Static_Void_byref_IntPtr_Object_Delegate_Delegate_Il2CppReferenceArray_1_Delegate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddStaticCallback_Internal_Static_Void_String_Delegate_Delegate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryAssignNotificationIdToCallback_Internal_Static_Boolean_IntPtr_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryRemoveCallbackByNotificationId_Internal_Static_Boolean_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAndRemoveCallback_Internal_Static_Boolean_IntPtr_byref_TCallback_byref_TCallbackInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetStructCallback_Internal_Static_Boolean_IntPtr_byref_TDelegate_byref_TCallbackInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryAllocate_Private_Static_Boolean_byref_IntPtr_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryAllocate_Private_Static_Boolean_byref_IntPtr_Nullable_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryAllocate_Private_Static_Boolean_byref_IntPtr_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryAllocate_Private_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryAllocateCacheOnly_Private_Static_Boolean_byref_IntPtr_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryRelease_Private_Static_Boolean_byref_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryFetch_Private_Static_Boolean_IntPtr_byref_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryFetch_Private_Static_Boolean_IntPtr_byref_Nullable_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryFetchHandle_Private_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_THandle_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryFetch_Private_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryFetch_Private_Static_Boolean_IntPtr_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_IntPtr_byref_THandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvert_Internal_Static_Boolean_TSource_byref_TTarget_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Handle_byref_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Il2CppStructArray_1_Byte_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_String_byref_Il2CppStructArray_1_Byte_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_String_byref_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Il2CppArrayBase_1_T_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Il2CppArrayBase_1_T_byref_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvert_Internal_Static_Boolean_Il2CppArrayBase_1_TSource_byref_Il2CppArrayBase_1_TTarget_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Int32_byref_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Boolean_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Nullable_1_DateTimeOffset_byref_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Int64_byref_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanRemoveCallback_Private_Static_Boolean_IntPtr_TCallbackInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAndRemoveCallback_Private_Static_Boolean_IntPtr_TCallbackInfo_byref_TCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetStaticCallback_Internal_Static_Boolean_String_byref_TCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetStructCallback_Private_Static_Boolean_IntPtr_byref_TCallback_0;

  static Helper()
  {
    Il2CppClassPointerStore<Helper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices", nameof (Helper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Helper>.NativeClassPtr);
    Helper.NativeFieldInfoPtr_s_Allocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper>.NativeClassPtr, nameof (s_Allocations));
    Helper.NativeFieldInfoPtr_s_Callbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper>.NativeClassPtr, nameof (s_Callbacks));
    Helper.NativeFieldInfoPtr_s_StaticCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper>.NativeClassPtr, nameof (s_StaticCallbacks));
    Helper.NativeMethodInfoPtr_GetAllocationCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663769);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Il2CppArrayBase_1_T_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663770);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663771);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_TSource_byref_TTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663772);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663773);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663774);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Int64_byref_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663775);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663776 /*0x060001E0*/);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663777);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663778);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663779);
    Helper.NativeMethodInfoPtr_TryMarshalGetHandle_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_THandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663780);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Il2CppArrayBase_1_TSource_byref_Il2CppArrayBase_1_TTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663781);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_TTarget_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663782);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_TTarget_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663783);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663784);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Il2CppStructArray_1_Byte_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663785);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663786);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663787);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_T_byref_T_TEnum_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663788);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_ISettable_byref_TTarget_TEnum_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663789);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Int32_byref_Nullable_1_Boolean_TEnum_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663790);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_T_byref_Nullable_1_T_TEnum_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663791);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_T_TEnum_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663792 /*0x060001F0*/);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Nullable_1_IntPtr_TEnum_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663793);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_String_TEnum_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663794);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_TPublic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663795);
    Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_TCallbackInfo_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663796);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663797);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_TTarget_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663798);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Handle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663799);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663800);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663801);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663802);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663803);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_byref_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663804);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663805);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_Int64_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663806);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663807);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_Il2CppStructArray_1_Byte_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663808 /*0x06000200*/);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663809 /*0x06000201*/);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_T_T_byref_TEnum_TEnum_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663810 /*0x06000202*/);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_TTarget_ISettable_byref_TEnum_TEnum_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663811 /*0x06000203*/);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_T_Nullable_1_T_byref_TEnum_TEnum_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663812 /*0x06000204*/);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Handle_byref_TEnum_TEnum_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663813 /*0x06000205*/);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_String_byref_TEnum_TEnum_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663814 /*0x06000206*/);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_Int32_Nullable_1_Boolean_byref_TEnum_TEnum_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663815 /*0x06000207*/);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_TPublic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663816 /*0x06000208*/);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663817 /*0x06000209*/);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663818 /*0x0600020A*/);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663819 /*0x0600020B*/);
    Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663820 /*0x0600020C*/);
    Helper.NativeMethodInfoPtr_TryMarshalCopy_Internal_Static_Boolean_IntPtr_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663821 /*0x0600020D*/);
    Helper.NativeMethodInfoPtr_TryMarshalAllocate_Internal_Static_Boolean_byref_IntPtr_Int32_byref_Allocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663822 /*0x0600020E*/);
    Helper.NativeMethodInfoPtr_TryMarshalAllocate_Internal_Static_Boolean_byref_IntPtr_UInt32_byref_Allocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663823 /*0x0600020F*/);
    Helper.NativeMethodInfoPtr_TryMarshalAllocate_Internal_Static_Boolean_byref_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663824 /*0x06000210*/);
    Helper.NativeMethodInfoPtr_TryMarshalAllocate_Internal_Static_Boolean_byref_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663825);
    Helper.NativeMethodInfoPtr_TryMarshalDispose_Internal_Static_Boolean_byref_TDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663826);
    Helper.NativeMethodInfoPtr_TryMarshalDispose_Internal_Static_Boolean_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663827);
    Helper.NativeMethodInfoPtr_TryMarshalDispose_Internal_Static_Boolean_byref_IntPtr_TEnum_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663828);
    Helper.NativeMethodInfoPtr_GetDefault_Internal_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663829);
    Helper.NativeMethodInfoPtr_AddCallback_Internal_Static_Void_byref_IntPtr_Object_Delegate_Delegate_Il2CppReferenceArray_1_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663830);
    Helper.NativeMethodInfoPtr_AddStaticCallback_Internal_Static_Void_String_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663831);
    Helper.NativeMethodInfoPtr_TryAssignNotificationIdToCallback_Internal_Static_Boolean_IntPtr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663832);
    Helper.NativeMethodInfoPtr_TryRemoveCallbackByNotificationId_Internal_Static_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663833);
    Helper.NativeMethodInfoPtr_TryGetAndRemoveCallback_Internal_Static_Boolean_IntPtr_byref_TCallback_byref_TCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663834);
    Helper.NativeMethodInfoPtr_TryGetStructCallback_Internal_Static_Boolean_IntPtr_byref_TDelegate_byref_TCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663835);
    Helper.NativeMethodInfoPtr_TryAllocate_Private_Static_Boolean_byref_IntPtr_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663836);
    Helper.NativeMethodInfoPtr_TryAllocate_Private_Static_Boolean_byref_IntPtr_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663837);
    Helper.NativeMethodInfoPtr_TryAllocate_Private_Static_Boolean_byref_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663838);
    Helper.NativeMethodInfoPtr_TryAllocate_Private_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663839);
    Helper.NativeMethodInfoPtr_TryAllocateCacheOnly_Private_Static_Boolean_byref_IntPtr_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663840 /*0x06000220*/);
    Helper.NativeMethodInfoPtr_TryRelease_Private_Static_Boolean_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663841);
    Helper.NativeMethodInfoPtr_TryFetch_Private_Static_Boolean_IntPtr_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663842);
    Helper.NativeMethodInfoPtr_TryFetch_Private_Static_Boolean_IntPtr_byref_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663843);
    Helper.NativeMethodInfoPtr_TryFetchHandle_Private_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_THandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663844);
    Helper.NativeMethodInfoPtr_TryFetch_Private_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663845);
    Helper.NativeMethodInfoPtr_TryFetch_Private_Static_Boolean_IntPtr_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663846);
    Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_IntPtr_byref_THandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663847);
    Helper.NativeMethodInfoPtr_TryConvert_Internal_Static_Boolean_TSource_byref_TTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663848);
    Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Handle_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663849);
    Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Il2CppStructArray_1_Byte_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663850);
    Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_String_byref_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663851);
    Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_String_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663852);
    Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Il2CppArrayBase_1_T_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663853);
    Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Il2CppArrayBase_1_T_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663854);
    Helper.NativeMethodInfoPtr_TryConvert_Internal_Static_Boolean_Il2CppArrayBase_1_TSource_byref_Il2CppArrayBase_1_TTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663855);
    Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663856 /*0x06000230*/);
    Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663857);
    Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Nullable_1_DateTimeOffset_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663858);
    Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Int64_byref_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663859);
    Helper.NativeMethodInfoPtr_CanRemoveCallback_Private_Static_Boolean_IntPtr_TCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663860);
    Helper.NativeMethodInfoPtr_TryGetAndRemoveCallback_Private_Static_Boolean_IntPtr_TCallbackInfo_byref_TCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663861);
    Helper.NativeMethodInfoPtr_TryGetStaticCallback_Internal_Static_Boolean_String_byref_TCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663862);
    Helper.NativeMethodInfoPtr_TryGetStructCallback_Private_Static_Boolean_IntPtr_byref_TCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100663863);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364215, XrefRangeEnd = 364223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetAllocationCount()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_GetAllocationCount_Public_Static_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364223, XrefRangeEnd = 364244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<T>(Il2CppArrayBase<T> source, out uint target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref target;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_Il2CppArrayBase_1_T_byref_UInt32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(455)]
  [CachedScanResults(RefRangeStart = 364265, RefRangeEnd = 364720, XrefRangeStart = 364244, XrefRangeEnd = 364265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<T>(System.IntPtr source, out T target) where T : Handle, new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local1 = ref (*(T*) &zero);
    }
    else
      local1 = ref target;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    if (!typeof (T).IsValueType)
    {
      ref T local2 = ref target;
      System.IntPtr num4 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num4 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num4, false, false);
      local2 = (T) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 364725, RefRangeEnd = 364732, XrefRangeStart = 364720, XrefRangeEnd = 364725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<TSource, TTarget>(TSource source, out TTarget target) where TTarget : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    TSource& local1;
    if (!typeof (TSource).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TSource> local2 = (object) source;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TSource&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TSource&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref source;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    TTarget& local3;
    if (!typeof (TTarget).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local3 = ref (*(TTarget*) &zero);
    }
    else
      local3 = ref target;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local3;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_TSource_byref_TTarget_0<TSource, TTarget>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    if (!typeof (TTarget).IsValueType)
    {
      ref TTarget local4 = ref target;
      System.IntPtr num4 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num4 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TTarget>(num4, false, false);
      local4 = (TTarget) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(65)]
  [CachedScanResults(RefRangeStart = 364735, RefRangeEnd = 364800, XrefRangeStart = 364732, XrefRangeEnd = 364735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet(int source, out bool target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &source;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref target;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Int32_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364800, XrefRangeEnd = 364803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet(bool source, out int target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &source;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref target;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Boolean_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(24)]
  [CachedScanResults(RefRangeStart = 364819, RefRangeEnd = 364843, XrefRangeStart = 364803, XrefRangeEnd = 364819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet(long source, out Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> target)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Int64_byref_Nullable_1_DateTimeOffset_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> local = ref target;
    System.IntPtr pointer = zero;
    Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>) null : new Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>(pointer);
    local = nullable;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 364848, RefRangeEnd = 364851, XrefRangeStart = 364843, XrefRangeEnd = 364848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<T>(
    System.IntPtr source,
    out Il2CppArrayBase<T> target,
    int arrayLength,
    bool isElementAllocated)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isElementAllocated;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_Int32_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppArrayBase<T> local = ref target;
    System.IntPtr num4 = zero;
    Il2CppArrayBase<T> il2CppArrayBase = num4 == System.IntPtr.Zero ? (Il2CppArrayBase<T>) null : new Il2CppArrayBase<T>(num4);
    local = il2CppArrayBase;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 364856, RefRangeEnd = 364857, XrefRangeStart = 364851, XrefRangeEnd = 364856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<T>(
    System.IntPtr source,
    out Il2CppArrayBase<T> target,
    uint arrayLength,
    bool isElementAllocated)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isElementAllocated;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_UInt32_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppArrayBase<T> local = ref target;
    System.IntPtr num4 = zero;
    Il2CppArrayBase<T> il2CppArrayBase = num4 == System.IntPtr.Zero ? (Il2CppArrayBase<T>) null : new Il2CppArrayBase<T>(num4);
    local = il2CppArrayBase;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364857, XrefRangeEnd = 364866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<T>(
    System.IntPtr source,
    out Il2CppArrayBase<T> target,
    int arrayLength)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppArrayBase<T> local = ref target;
    System.IntPtr num4 = zero;
    Il2CppArrayBase<T> il2CppArrayBase = num4 == System.IntPtr.Zero ? (Il2CppArrayBase<T>) null : new Il2CppArrayBase<T>(num4);
    local = il2CppArrayBase;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 364875, RefRangeEnd = 364890, XrefRangeStart = 364866, XrefRangeEnd = 364875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<T>(
    System.IntPtr source,
    out Il2CppArrayBase<T> target,
    uint arrayLength)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_UInt32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppArrayBase<T> local = ref target;
    System.IntPtr num4 = zero;
    Il2CppArrayBase<T> il2CppArrayBase = num4 == System.IntPtr.Zero ? (Il2CppArrayBase<T>) null : new Il2CppArrayBase<T>(num4);
    local = il2CppArrayBase;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 364895, RefRangeEnd = 364907, XrefRangeStart = 364890, XrefRangeEnd = 364895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGetHandle<THandle>(
    System.IntPtr source,
    out Il2CppArrayBase<THandle> target,
    uint arrayLength)
    where THandle : Handle, new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGetHandle_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_THandle_UInt32_0<THandle>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppArrayBase<THandle> local = ref target;
    System.IntPtr num4 = zero;
    Il2CppArrayBase<THandle> il2CppArrayBase = num4 == System.IntPtr.Zero ? (Il2CppArrayBase<THandle>) null : new Il2CppArrayBase<THandle>(num4);
    local = il2CppArrayBase;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364907, XrefRangeEnd = 364912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<TSource, TTarget>(
    Il2CppArrayBase<TSource> source,
    out Il2CppArrayBase<TTarget> target)
    where TSource : new()
    where TTarget : class, new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_Il2CppArrayBase_1_TSource_byref_Il2CppArrayBase_1_TTarget_0<TSource, TTarget>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppArrayBase<TTarget> local = ref target;
    System.IntPtr num4 = zero;
    Il2CppArrayBase<TTarget> il2CppArrayBase = num4 == System.IntPtr.Zero ? (Il2CppArrayBase<TTarget>) null : new Il2CppArrayBase<TTarget>(num4);
    local = il2CppArrayBase;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 364926, RefRangeEnd = 364928, XrefRangeStart = 364912, XrefRangeEnd = 364926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<TSource, TTarget>(
    System.IntPtr source,
    out Il2CppArrayBase<TTarget> target,
    int arrayLength)
    where TSource : new()
    where TTarget : class, new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_TTarget_Int32_0<TSource, TTarget>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppArrayBase<TTarget> local = ref target;
    System.IntPtr num4 = zero;
    Il2CppArrayBase<TTarget> il2CppArrayBase = num4 == System.IntPtr.Zero ? (Il2CppArrayBase<TTarget>) null : new Il2CppArrayBase<TTarget>(num4);
    local = il2CppArrayBase;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 364946, RefRangeEnd = 364949, XrefRangeStart = 364928, XrefRangeEnd = 364946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<TSource, TTarget>(
    System.IntPtr source,
    out Il2CppArrayBase<TTarget> target,
    uint arrayLength)
    where TSource : new()
    where TTarget : class, new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_TTarget_UInt32_0<TSource, TTarget>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppArrayBase<TTarget> local = ref target;
    System.IntPtr num4 = zero;
    Il2CppArrayBase<TTarget> il2CppArrayBase = num4 == System.IntPtr.Zero ? (Il2CppArrayBase<TTarget>) null : new Il2CppArrayBase<TTarget>(num4);
    local = il2CppArrayBase;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364949, XrefRangeEnd = 364970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<T>(System.IntPtr source, out Il2CppSystem.Nullable<T> target) where T : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Nullable_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppSystem.Nullable<T> local = ref target;
    System.IntPtr pointer = zero;
    Il2CppSystem.Nullable<T> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<T>) null : new Il2CppSystem.Nullable<T>(pointer);
    local = nullable;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 364982, RefRangeEnd = 364985, XrefRangeStart = 364970, XrefRangeEnd = 364982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet(Il2CppStructArray<byte> source, out string target)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Il2CppStructArray_1_Byte_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    target = IL2CPP.Il2CppStringToManaged(zero);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(355)]
  [CachedScanResults(RefRangeStart = 364991, RefRangeEnd = 365346, XrefRangeStart = 364985, XrefRangeEnd = 364991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet(System.IntPtr source, out Il2CppSystem.Object target)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Object_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppSystem.Object local = ref target;
    System.IntPtr pointer = zero;
    Il2CppSystem.Object @object = pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    local = @object;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(500)]
  [CachedScanResults(RefRangeStart = 365361, RefRangeEnd = 365861, XrefRangeStart = 365346, XrefRangeEnd = 365361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet(System.IntPtr source, out string target)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    target = IL2CPP.Il2CppStringToManaged(zero);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 365872, RefRangeEnd = 365876, XrefRangeStart = 365861, XrefRangeEnd = 365872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<T, TEnum>(
    T source,
    out T target,
    TEnum currentEnum,
    TEnum comparisonEnum)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) source;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref source;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    T& local3;
    if (!typeof (T).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local3 = ref (*(T*) &zero);
    }
    else
      local3 = ref target;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local3;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local4;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local5 = (object) currentEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local4 = local5 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local5 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local5 as Il2CppObjectBase);
    }
    else
      local4 = ref currentEnum;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local4;
    System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local6;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local7 = (object) comparisonEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local6 = local7 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local7 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local7 as Il2CppObjectBase);
    }
    else
      local6 = ref comparisonEnum;
    *(System.IntPtr*) num3 = (System.IntPtr) ref local6;
    System.IntPtr num4;
    System.IntPtr num5 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_T_byref_T_TEnum_TEnum_0<T, TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num4);
    Il2CppException.RaiseExceptionIfNecessary(num4);
    if (!typeof (T).IsValueType)
    {
      ref T local8 = ref target;
      System.IntPtr num6 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num6 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num6, false, false);
      local8 = (T) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num5);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 365887, RefRangeEnd = 365889, XrefRangeStart = 365876, XrefRangeEnd = 365887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<TTarget, TEnum>(
    ISettable source,
    out TTarget target,
    TEnum currentEnum,
    TEnum comparisonEnum)
    where TTarget : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    TTarget& local1;
    if (!typeof (TTarget).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local1 = ref (*(TTarget*) &zero);
    }
    else
      local1 = ref target;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local2;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local3 = (object) currentEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local2 = local3 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local3 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local3 as Il2CppObjectBase);
    }
    else
      local2 = ref currentEnum;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local2;
    System.IntPtr num3 = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local4;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local5 = (object) comparisonEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local4 = local5 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local5 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local5 as Il2CppObjectBase);
    }
    else
      local4 = ref comparisonEnum;
    *(System.IntPtr*) num3 = (System.IntPtr) ref local4;
    System.IntPtr num4;
    System.IntPtr num5 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_ISettable_byref_TTarget_TEnum_TEnum_0<TTarget, TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num4);
    Il2CppException.RaiseExceptionIfNecessary(num4);
    if (!typeof (TTarget).IsValueType)
    {
      ref TTarget local6 = ref target;
      System.IntPtr num6 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num6 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TTarget>(num6, false, false);
      local6 = (TTarget) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num5);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 365908, RefRangeEnd = 365912, XrefRangeStart = 365889, XrefRangeEnd = 365908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<TEnum>(
    int source,
    out Il2CppSystem.Nullable<bool> target,
    TEnum currentEnum,
    TEnum comparisonEnum)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local1;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local2 = (object) currentEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref currentEnum;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local1;
    System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local3;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local4 = (object) comparisonEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local3 = local4 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
    }
    else
      local3 = ref comparisonEnum;
    *(System.IntPtr*) num3 = (System.IntPtr) ref local3;
    System.IntPtr num4;
    System.IntPtr num5 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_Int32_byref_Nullable_1_Boolean_TEnum_TEnum_0<TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num4);
    Il2CppException.RaiseExceptionIfNecessary(num4);
    ref Il2CppSystem.Nullable<bool> local5 = ref target;
    System.IntPtr pointer = zero;
    Il2CppSystem.Nullable<bool> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<bool>) null : new Il2CppSystem.Nullable<bool>(pointer);
    local5 = nullable;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num5);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 365923, RefRangeEnd = 365927, XrefRangeStart = 365912, XrefRangeEnd = 365923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<T, TEnum>(
    T source,
    out Il2CppSystem.Nullable<T> target,
    TEnum currentEnum,
    TEnum comparisonEnum)
    where T : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) source;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref source;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr3;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local3;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local4 = (object) currentEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local3 = local4 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
    }
    else
      local3 = ref currentEnum;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local3;
    System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local5;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local6 = (object) comparisonEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local5 = local6 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local6 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local6 as Il2CppObjectBase);
    }
    else
      local5 = ref comparisonEnum;
    *(System.IntPtr*) num3 = (System.IntPtr) ref local5;
    System.IntPtr num4;
    System.IntPtr num5 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_T_byref_Nullable_1_T_TEnum_TEnum_0<T, TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num4);
    Il2CppException.RaiseExceptionIfNecessary(num4);
    ref Il2CppSystem.Nullable<T> local7 = ref target;
    System.IntPtr pointer = zero;
    Il2CppSystem.Nullable<T> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<T>) null : new Il2CppSystem.Nullable<T>(pointer);
    local7 = nullable;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num5);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 365938, RefRangeEnd = 365944, XrefRangeStart = 365927, XrefRangeEnd = 365938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<T, TEnum>(
    System.IntPtr source,
    out T target,
    TEnum currentEnum,
    TEnum comparisonEnum)
    where T : Handle, new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local1 = ref (*(T*) &zero);
    }
    else
      local1 = ref target;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local2;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local3 = (object) currentEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local2 = local3 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local3 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local3 as Il2CppObjectBase);
    }
    else
      local2 = ref currentEnum;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local2;
    System.IntPtr num3 = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local4;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local5 = (object) comparisonEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local4 = local5 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local5 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local5 as Il2CppObjectBase);
    }
    else
      local4 = ref comparisonEnum;
    *(System.IntPtr*) num3 = (System.IntPtr) ref local4;
    System.IntPtr num4;
    System.IntPtr num5 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_T_TEnum_TEnum_0<T, TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num4);
    Il2CppException.RaiseExceptionIfNecessary(num4);
    if (!typeof (T).IsValueType)
    {
      ref T local6 = ref target;
      System.IntPtr num6 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num6 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num6, false, false);
      local6 = (T) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num5);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 365958, RefRangeEnd = 365960, XrefRangeStart = 365944, XrefRangeEnd = 365958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<TEnum>(
    System.IntPtr source,
    out Il2CppSystem.Nullable<System.IntPtr> target,
    TEnum currentEnum,
    TEnum comparisonEnum)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local1;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local2 = (object) currentEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref currentEnum;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local1;
    System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local3;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local4 = (object) comparisonEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local3 = local4 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
    }
    else
      local3 = ref comparisonEnum;
    *(System.IntPtr*) num3 = (System.IntPtr) ref local3;
    System.IntPtr num4;
    System.IntPtr num5 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Nullable_1_IntPtr_TEnum_TEnum_0<TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num4);
    Il2CppException.RaiseExceptionIfNecessary(num4);
    ref Il2CppSystem.Nullable<System.IntPtr> local5 = ref target;
    System.IntPtr pointer = zero;
    Il2CppSystem.Nullable<System.IntPtr> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<System.IntPtr>) null : new Il2CppSystem.Nullable<System.IntPtr>(pointer);
    local5 = nullable;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num5);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 365973, RefRangeEnd = 365985, XrefRangeStart = 365960, XrefRangeEnd = 365973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<TEnum>(
    System.IntPtr source,
    out string target,
    TEnum currentEnum,
    TEnum comparisonEnum)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local1;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local2 = (object) currentEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref currentEnum;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local1;
    System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local3;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local4 = (object) comparisonEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local3 = local4 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
    }
    else
      local3 = ref comparisonEnum;
    *(System.IntPtr*) num3 = (System.IntPtr) ref local3;
    System.IntPtr num4;
    System.IntPtr num5 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_String_TEnum_TEnum_0<TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num4);
    Il2CppException.RaiseExceptionIfNecessary(num4);
    target = IL2CPP.Il2CppStringToManaged(zero);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num5);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 366001, RefRangeEnd = 366015, XrefRangeStart = 365985, XrefRangeEnd = 366001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<TInternal, TPublic>(System.IntPtr source, out TPublic target)
    where TInternal : new()
    where TPublic : class, new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    TPublic& local1;
    if (!typeof (TPublic).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local1 = ref (*(TPublic*) &zero);
    }
    else
      local1 = ref target;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_TPublic_0<TInternal, TPublic>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    if (!typeof (TPublic).IsValueType)
    {
      ref TPublic local2 = ref target;
      System.IntPtr num4 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num4 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TPublic>(num4, false, false);
      local2 = (TPublic) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366015, XrefRangeEnd = 366021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalGet<TCallbackInfoInternal, TCallbackInfo>(
    System.IntPtr callbackInfoAddress,
    out TCallbackInfo callbackInfo,
    out System.IntPtr clientDataAddress)
    where TCallbackInfoInternal : new()
    where TCallbackInfo : class, new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &callbackInfoAddress;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    TCallbackInfo& local1;
    if (!typeof (TCallbackInfo).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local1 = ref (*(TCallbackInfo*) &zero);
    }
    else
      local1 = ref callbackInfo;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientDataAddress;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_TCallbackInfo_byref_IntPtr_0<TCallbackInfoInternal, TCallbackInfo>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    if (!typeof (TCallbackInfo).IsValueType)
    {
      ref TCallbackInfo local2 = ref callbackInfo;
      System.IntPtr num4 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num4 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TCallbackInfo>(num4, false, false);
      local2 = (TCallbackInfo) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 366021, RefRangeEnd = 366022, XrefRangeStart = 366021, XrefRangeEnd = 366021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet<T>(ref T target, T source)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) source;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref source;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_T_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref T local3 = ref target;
    System.IntPtr num4 = ptr;
    // ISSUE: variable of the null type
    __Null valueGeneric = num4 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num4, false, false);
    local3 = (T) valueGeneric;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 366039, RefRangeEnd = 366040, XrefRangeStart = 366022, XrefRangeEnd = 366039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet<TTarget>(ref TTarget target, Il2CppSystem.Object source) where TTarget : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_TTarget_Object_0<TTarget>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    ref TTarget local = ref target;
    System.IntPtr num3 = ptr;
    // ISSUE: variable of the null type
    __Null valueGeneric = num3 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TTarget>(num3, false, false);
    local = (TTarget) valueGeneric;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(484)]
  [CachedScanResults(RefRangeStart = 366043, RefRangeEnd = 366527, XrefRangeStart = 366040, XrefRangeEnd = 366043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet(ref System.IntPtr target, Handle source)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Handle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 366532, RefRangeEnd = 366534, XrefRangeStart = 366527, XrefRangeEnd = 366532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet<T>(ref System.IntPtr target, Il2CppSystem.Nullable<T> source) where T : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) source));
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Nullable_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366534, XrefRangeEnd = 366539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet<T>(
    ref System.IntPtr target,
    Il2CppArrayBase<T> source,
    bool isElementAllocated)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isElementAllocated;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 366557, RefRangeEnd = 366559, XrefRangeStart = 366539, XrefRangeEnd = 366557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet<T>(ref System.IntPtr target, Il2CppArrayBase<T> source)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366559, XrefRangeEnd = 366568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet<T>(
    ref System.IntPtr target,
    Il2CppArrayBase<T> source,
    out int arrayLength,
    bool isElementAllocated)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref arrayLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isElementAllocated;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_byref_Int32_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366568, XrefRangeEnd = 366582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet<T>(
    ref System.IntPtr target,
    Il2CppArrayBase<T> source,
    out uint arrayLength,
    bool isElementAllocated)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref arrayLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isElementAllocated;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_byref_UInt32_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 366603, RefRangeEnd = 366612, XrefRangeStart = 366582, XrefRangeEnd = 366603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet<T>(
    ref System.IntPtr target,
    Il2CppArrayBase<T> source,
    out uint arrayLength)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref arrayLength;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_byref_UInt32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(28)]
  [CachedScanResults(RefRangeStart = 366631, RefRangeEnd = 366659, XrefRangeStart = 366612, XrefRangeEnd = 366631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet(ref long target, Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> source)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) source));
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_Int64_Nullable_1_DateTimeOffset_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(91)]
  [CachedScanResults(RefRangeStart = 366662, RefRangeEnd = 366753, XrefRangeStart = 366659, XrefRangeEnd = 366662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet(ref int target, bool source)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 366757, RefRangeEnd = 366760, XrefRangeStart = 366753, XrefRangeEnd = 366757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet(
    ref Il2CppStructArray<byte> target,
    string source,
    int length)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(source);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_Il2CppStructArray_1_Byte_String_Int32_0, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    ref Il2CppStructArray<byte> local = ref target;
    System.IntPtr num3 = ptr;
    Il2CppStructArray<byte> il2CppStructArray = num3 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(num3);
    local = il2CppStructArray;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(609)]
  [CachedScanResults(RefRangeStart = 366778, RefRangeEnd = 367387, XrefRangeStart = 366760, XrefRangeEnd = 366778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet(ref System.IntPtr target, string source)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(source);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 367396, RefRangeEnd = 367398, XrefRangeStart = 367387, XrefRangeEnd = 367396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet<T, TEnum>(
    ref T target,
    T source,
    ref TEnum currentEnum,
    TEnum comparisonEnum,
    Il2CppSystem.IDisposable disposable = null)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr1 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    System.IntPtr* numPtr3 = &ptr1;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) source;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref source;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentEnum);
    System.IntPtr* numPtr4 = &ptr2;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr4;
    System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local3;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local4 = (object) comparisonEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local3 = local4 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
    }
    else
      local3 = ref comparisonEnum;
    *(System.IntPtr*) num3 = (System.IntPtr) ref local3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) disposable);
    System.IntPtr num4;
    System.IntPtr num5 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_T_T_byref_TEnum_TEnum_IDisposable_0<T, TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num4);
    Il2CppException.RaiseExceptionIfNecessary(num4);
    ref T local5 = ref target;
    System.IntPtr num6 = ptr1;
    // ISSUE: variable of the null type
    __Null valueGeneric1 = num6 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num6, false, false);
    local5 = (T) valueGeneric1;
    ref TEnum local6 = ref currentEnum;
    System.IntPtr num7 = ptr2;
    // ISSUE: variable of the null type
    __Null valueGeneric2 = num7 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TEnum>(num7, false, false);
    local6 = (TEnum) valueGeneric2;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num5);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 367407, RefRangeEnd = 367408, XrefRangeStart = 367398, XrefRangeEnd = 367407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet<TTarget, TEnum>(
    ref TTarget target,
    ISettable source,
    ref TEnum currentEnum,
    TEnum comparisonEnum,
    Il2CppSystem.IDisposable disposable = null)
    where TTarget : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr1 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    System.IntPtr* numPtr3 = &ptr1;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentEnum);
    System.IntPtr* numPtr4 = &ptr2;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr4;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local1;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local2 = (object) comparisonEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref comparisonEnum;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) disposable);
    System.IntPtr num3;
    System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_TTarget_ISettable_byref_TEnum_TEnum_IDisposable_0<TTarget, TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    ref TTarget local3 = ref target;
    System.IntPtr num5 = ptr1;
    // ISSUE: variable of the null type
    __Null valueGeneric1 = num5 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TTarget>(num5, false, false);
    local3 = (TTarget) valueGeneric1;
    ref TEnum local4 = ref currentEnum;
    System.IntPtr num6 = ptr2;
    // ISSUE: variable of the null type
    __Null valueGeneric2 = num6 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TEnum>(num6, false, false);
    local4 = (TEnum) valueGeneric2;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num4);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 367417, RefRangeEnd = 367419, XrefRangeStart = 367408, XrefRangeEnd = 367417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet<T, TEnum>(
    ref T target,
    Il2CppSystem.Nullable<T> source,
    ref TEnum currentEnum,
    TEnum comparisonEnum,
    Il2CppSystem.IDisposable disposable = null)
    where T : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr1 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    System.IntPtr* numPtr3 = &ptr1;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) source));
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentEnum);
    System.IntPtr* numPtr4 = &ptr2;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr4;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local1;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local2 = (object) comparisonEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref comparisonEnum;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) disposable);
    System.IntPtr num3;
    System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_T_Nullable_1_T_byref_TEnum_TEnum_IDisposable_0<T, TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    ref T local3 = ref target;
    System.IntPtr num5 = ptr1;
    // ISSUE: variable of the null type
    __Null valueGeneric1 = num5 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num5, false, false);
    local3 = (T) valueGeneric1;
    ref TEnum local4 = ref currentEnum;
    System.IntPtr num6 = ptr2;
    // ISSUE: variable of the null type
    __Null valueGeneric2 = num6 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TEnum>(num6, false, false);
    local4 = (TEnum) valueGeneric2;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num4);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 367427, RefRangeEnd = 367429, XrefRangeStart = 367419, XrefRangeEnd = 367427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet<TEnum>(
    ref System.IntPtr target,
    Handle source,
    ref TEnum currentEnum,
    TEnum comparisonEnum,
    Il2CppSystem.IDisposable disposable = null)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
    numPtr1[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentEnum);
    System.IntPtr* numPtr2 = &ptr;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local1;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local2 = (object) comparisonEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref comparisonEnum;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) disposable);
    System.IntPtr num3;
    System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Handle_byref_TEnum_TEnum_IDisposable_0<TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    ref TEnum local3 = ref currentEnum;
    System.IntPtr num5 = ptr;
    // ISSUE: variable of the null type
    __Null valueGeneric = num5 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TEnum>(num5, false, false);
    local3 = (TEnum) valueGeneric;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num4);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 367437, RefRangeEnd = 367442, XrefRangeStart = 367429, XrefRangeEnd = 367437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet<TEnum>(
    ref System.IntPtr target,
    string source,
    ref TEnum currentEnum,
    TEnum comparisonEnum,
    Il2CppSystem.IDisposable disposable = null)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
    numPtr1[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(source);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentEnum);
    System.IntPtr* numPtr2 = &ptr;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local1;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local2 = (object) comparisonEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref comparisonEnum;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) disposable);
    System.IntPtr num3;
    System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_String_byref_TEnum_TEnum_IDisposable_0<TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    ref TEnum local3 = ref currentEnum;
    System.IntPtr num5 = ptr;
    // ISSUE: variable of the null type
    __Null valueGeneric = num5 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TEnum>(num5, false, false);
    local3 = (TEnum) valueGeneric;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num4);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 367453, RefRangeEnd = 367455, XrefRangeStart = 367442, XrefRangeEnd = 367453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet<TEnum>(
    ref int target,
    Il2CppSystem.Nullable<bool> source,
    ref TEnum currentEnum,
    TEnum comparisonEnum,
    Il2CppSystem.IDisposable disposable = null)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
    numPtr1[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) source));
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentEnum);
    System.IntPtr* numPtr2 = &ptr;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local1;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local2 = (object) comparisonEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref comparisonEnum;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) disposable);
    System.IntPtr num3;
    System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_Int32_Nullable_1_Boolean_byref_TEnum_TEnum_IDisposable_0<TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    ref TEnum local3 = ref currentEnum;
    System.IntPtr num5 = ptr;
    // ISSUE: variable of the null type
    __Null valueGeneric = num5 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TEnum>(num5, false, false);
    local3 = (TEnum) valueGeneric;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num4);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 367462, RefRangeEnd = 367463, XrefRangeStart = 367455, XrefRangeEnd = 367462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet<TInternal, TPublic>(ref System.IntPtr target, TPublic source)
    where TInternal : new()
    where TPublic : class
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref target;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TPublic& local1;
    if (!typeof (TPublic).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TPublic> local2 = (object) source;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TPublic&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TPublic&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref source;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_TPublic_0<TInternal, TPublic>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367463, XrefRangeEnd = 367473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet<TInternal, TPublic>(
    ref System.IntPtr target,
    Il2CppArrayBase<TPublic> source,
    out int arrayLength)
    where TInternal : new()
    where TPublic : class
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref arrayLength;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_Int32_0<TInternal, TPublic>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 367487, RefRangeEnd = 367488, XrefRangeStart = 367473, XrefRangeEnd = 367487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet<TInternal, TPublic>(
    ref System.IntPtr target,
    Il2CppArrayBase<TPublic> source,
    out uint arrayLength)
    where TInternal : new()
    where TPublic : class
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref arrayLength;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_UInt32_0<TInternal, TPublic>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367488, XrefRangeEnd = 367500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet<TInternal, TPublic>(
    ref System.IntPtr target,
    Il2CppArrayBase<TPublic> source,
    out int arrayLength,
    bool isElementAllocated)
    where TInternal : new()
    where TPublic : class
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref arrayLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isElementAllocated;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_Int32_Boolean_0<TInternal, TPublic>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367500, XrefRangeEnd = 367505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalSet<TInternal, TPublic>(
    ref System.IntPtr target,
    Il2CppArrayBase<TPublic> source,
    out uint arrayLength,
    bool isElementAllocated)
    where TInternal : new()
    where TPublic : class
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref arrayLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isElementAllocated;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_UInt32_Boolean_0<TInternal, TPublic>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367505, XrefRangeEnd = 367509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalCopy(System.IntPtr target, Il2CppStructArray<byte> source)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryMarshalCopy_Internal_Static_Boolean_IntPtr_Il2CppStructArray_1_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 367529, RefRangeEnd = 367540, XrefRangeStart = 367509, XrefRangeEnd = 367529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalAllocate(
    ref System.IntPtr target,
    int size,
    out Helper.Allocation allocation)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryMarshalAllocate_Internal_Static_Boolean_byref_IntPtr_Int32_byref_Allocation_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Helper.Allocation local = ref allocation;
    System.IntPtr pointer = zero;
    Helper.Allocation allocation1 = pointer == System.IntPtr.Zero ? (Helper.Allocation) null : new Helper.Allocation(pointer);
    local = allocation1;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367540, XrefRangeEnd = 367544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalAllocate(
    ref System.IntPtr target,
    uint size,
    out Helper.Allocation allocation)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryMarshalAllocate_Internal_Static_Boolean_byref_IntPtr_UInt32_byref_Allocation_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Helper.Allocation local = ref allocation;
    System.IntPtr pointer = zero;
    Helper.Allocation allocation1 = pointer == System.IntPtr.Zero ? (Helper.Allocation) null : new Helper.Allocation(pointer);
    local = allocation1;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 367548, RefRangeEnd = 367558, XrefRangeStart = 367544, XrefRangeEnd = 367548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalAllocate(ref System.IntPtr target, int size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryMarshalAllocate_Internal_Static_Boolean_byref_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 367565, RefRangeEnd = 367572, XrefRangeStart = 367558, XrefRangeEnd = 367565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalAllocate(ref System.IntPtr target, uint size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryMarshalAllocate_Internal_Static_Boolean_byref_IntPtr_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 367574, RefRangeEnd = 367575, XrefRangeStart = 367572, XrefRangeEnd = 367574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalDispose<TDisposable>(ref TDisposable disposable)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) disposable);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalDispose_Internal_Static_Boolean_byref_TDisposable_0<TDisposable>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    ref TDisposable local = ref disposable;
    System.IntPtr num3 = ptr;
    // ISSUE: variable of the null type
    __Null valueGeneric = num3 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TDisposable>(num3, false, false);
    local = (TDisposable) valueGeneric;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(922)]
  [CachedScanResults(RefRangeStart = 367579, RefRangeEnd = 368501, XrefRangeStart = 367575, XrefRangeEnd = 367579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalDispose(ref System.IntPtr value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryMarshalDispose_Internal_Static_Boolean_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 368509, RefRangeEnd = 368515, XrefRangeStart = 368501, XrefRangeEnd = 368509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryMarshalDispose<TEnum>(
    ref System.IntPtr member,
    TEnum currentEnum,
    TEnum comparisonEnum)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref member;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local1;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local2 = (object) currentEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref currentEnum;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local3;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local4 = (object) comparisonEnum;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local3 = local4 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
    }
    else
      local3 = ref comparisonEnum;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local3;
    System.IntPtr num3;
    System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryMarshalDispose_Internal_Static_Boolean_byref_IntPtr_TEnum_TEnum_0<TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num4);
  }

  [CallerCount(100)]
  [CachedScanResults(RefRangeStart = 368515, RefRangeEnd = 368615, XrefRangeStart = 368515, XrefRangeEnd = 368515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T GetDefault<T>()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_GetDefault_Internal_Static_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(139)]
  [CachedScanResults(RefRangeStart = 368634, RefRangeEnd = 368773, XrefRangeStart = 368615, XrefRangeEnd = 368634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddCallback(
    ref System.IntPtr clientDataAddress,
    Il2CppSystem.Object clientData,
    Il2CppSystem.Delegate publicDelegate,
    Il2CppSystem.Delegate privateDelegate,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Delegate> structDelegates)
  {
    if (structDelegates == null)
      structDelegates = new Il2CppReferenceArray<Il2CppSystem.Delegate>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) ref clientDataAddress;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) publicDelegate);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) privateDelegate);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) structDelegates);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_AddCallback_Internal_Static_Void_byref_IntPtr_Object_Delegate_Delegate_Il2CppReferenceArray_1_Delegate_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 368788, RefRangeEnd = 368789, XrefRangeStart = 368773, XrefRangeEnd = 368788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddStaticCallback(
    string key,
    Il2CppSystem.Delegate publicDelegate,
    Il2CppSystem.Delegate privateDelegate)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) publicDelegate);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) privateDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_AddStaticCallback_Internal_Static_Void_String_Delegate_Delegate_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(40)]
  [CachedScanResults(RefRangeStart = 368799, RefRangeEnd = 368839, XrefRangeStart = 368789, XrefRangeEnd = 368799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryAssignNotificationIdToCallback(
    System.IntPtr clientDataAddress,
    ulong notificationId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &clientDataAddress;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &notificationId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryAssignNotificationIdToCallback_Internal_Static_Boolean_IntPtr_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(39)]
  [CachedScanResults(RefRangeStart = 368862, RefRangeEnd = 368901, XrefRangeStart = 368839, XrefRangeEnd = 368862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryRemoveCallbackByNotificationId(ulong notificationId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryRemoveCallbackByNotificationId_Internal_Static_Boolean_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 368946, RefRangeEnd = 368953, XrefRangeStart = 368901, XrefRangeEnd = 368946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryGetAndRemoveCallback<TCallback, TCallbackInfoInternal, TCallbackInfo>(
    System.IntPtr callbackInfoAddress,
    out TCallback callback,
    out TCallbackInfo callbackInfo)
    where TCallback : class
    where TCallbackInfoInternal : new()
    where TCallbackInfo : class, new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &callbackInfoAddress;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero1;
    // ISSUE: variable of a reference type
    TCallback& local1;
    if (!typeof (TCallback).IsValueType)
    {
      zero1 = System.IntPtr.Zero;
      local1 = ref (*(TCallback*) &zero1);
    }
    else
      local1 = ref callback;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero2;
    // ISSUE: variable of a reference type
    TCallbackInfo& local2;
    if (!typeof (TCallbackInfo).IsValueType)
    {
      zero2 = System.IntPtr.Zero;
      local2 = ref (*(TCallbackInfo*) &zero2);
    }
    else
      local2 = ref callbackInfo;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local2;
    System.IntPtr num3;
    System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryGetAndRemoveCallback_Internal_Static_Boolean_IntPtr_byref_TCallback_byref_TCallbackInfo_0<TCallback, TCallbackInfoInternal, TCallbackInfo>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    if (!typeof (TCallback).IsValueType)
    {
      ref TCallback local3 = ref callback;
      System.IntPtr num5 = zero1;
      // ISSUE: variable of the null type
      __Null valueGeneric = num5 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TCallback>(num5, false, false);
      local3 = (TCallback) valueGeneric;
    }
    if (!typeof (TCallbackInfo).IsValueType)
    {
      ref TCallbackInfo local4 = ref callbackInfo;
      System.IntPtr num6 = zero2;
      // ISSUE: variable of the null type
      __Null valueGeneric = num6 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TCallbackInfo>(num6, false, false);
      local4 = (TCallbackInfo) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num4);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 369003, RefRangeEnd = 369005, XrefRangeStart = 368953, XrefRangeEnd = 369003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryGetStructCallback<TDelegate, TCallbackInfoInternal, TCallbackInfo>(
    System.IntPtr callbackInfoAddress,
    out TDelegate callback,
    out TCallbackInfo callbackInfo)
    where TDelegate : class
    where TCallbackInfoInternal : new()
    where TCallbackInfo : class, new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &callbackInfoAddress;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero1;
    // ISSUE: variable of a reference type
    TDelegate& local1;
    if (!typeof (TDelegate).IsValueType)
    {
      zero1 = System.IntPtr.Zero;
      local1 = ref (*(TDelegate*) &zero1);
    }
    else
      local1 = ref callback;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero2;
    // ISSUE: variable of a reference type
    TCallbackInfo& local2;
    if (!typeof (TCallbackInfo).IsValueType)
    {
      zero2 = System.IntPtr.Zero;
      local2 = ref (*(TCallbackInfo*) &zero2);
    }
    else
      local2 = ref callbackInfo;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local2;
    System.IntPtr num3;
    System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryGetStructCallback_Internal_Static_Boolean_IntPtr_byref_TDelegate_byref_TCallbackInfo_0<TDelegate, TCallbackInfoInternal, TCallbackInfo>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    if (!typeof (TDelegate).IsValueType)
    {
      ref TDelegate local3 = ref callback;
      System.IntPtr num5 = zero1;
      // ISSUE: variable of the null type
      __Null valueGeneric = num5 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TDelegate>(num5, false, false);
      local3 = (TDelegate) valueGeneric;
    }
    if (!typeof (TCallbackInfo).IsValueType)
    {
      ref TCallbackInfo local4 = ref callbackInfo;
      System.IntPtr num6 = zero2;
      // ISSUE: variable of the null type
      __Null valueGeneric = num6 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TCallbackInfo>(num6, false, false);
      local4 = (TCallbackInfo) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num4);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 369025, RefRangeEnd = 369027, XrefRangeStart = 369005, XrefRangeEnd = 369025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryAllocate<T>(ref System.IntPtr target, T source)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref target;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) source;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref source;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryAllocate_Private_Static_Boolean_byref_IntPtr_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 369036, RefRangeEnd = 369037, XrefRangeStart = 369027, XrefRangeEnd = 369036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryAllocate<T>(ref System.IntPtr target, Il2CppSystem.Nullable<T> source) where T : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) source));
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryAllocate_Private_Static_Boolean_byref_IntPtr_Nullable_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 369052, RefRangeEnd = 369053, XrefRangeStart = 369037, XrefRangeEnd = 369052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryAllocate(ref System.IntPtr target, string source)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(source);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryAllocate_Private_Static_Boolean_byref_IntPtr_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 369123, RefRangeEnd = 369129, XrefRangeStart = 369053, XrefRangeEnd = 369123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryAllocate<T>(
    ref System.IntPtr target,
    Il2CppArrayBase<T> source,
    bool isElementAllocated)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isElementAllocated;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryAllocate_Private_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 369138, RefRangeEnd = 369139, XrefRangeStart = 369129, XrefRangeEnd = 369138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryAllocateCacheOnly<T>(ref System.IntPtr target, T source)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref target;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) source;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref source;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryAllocateCacheOnly_Private_Static_Boolean_byref_IntPtr_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(130)]
  [CachedScanResults(RefRangeStart = 369199, RefRangeEnd = 369329, XrefRangeStart = 369139, XrefRangeEnd = 369199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryRelease(ref System.IntPtr target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref target
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryRelease_Private_Static_Boolean_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 369362, RefRangeEnd = 369365, XrefRangeStart = 369329, XrefRangeEnd = 369362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryFetch<T>(System.IntPtr source, out T target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local1 = ref (*(T*) &zero);
    }
    else
      local1 = ref target;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryFetch_Private_Static_Boolean_IntPtr_byref_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    if (!typeof (T).IsValueType)
    {
      ref T local2 = ref target;
      System.IntPtr num4 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num4 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num4, false, false);
      local2 = (T) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 369400, RefRangeEnd = 369402, XrefRangeStart = 369365, XrefRangeEnd = 369400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryFetch<T>(System.IntPtr source, out Il2CppSystem.Nullable<T> target) where T : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryFetch_Private_Static_Boolean_IntPtr_byref_Nullable_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppSystem.Nullable<T> local = ref target;
    System.IntPtr pointer = zero;
    Il2CppSystem.Nullable<T> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<T>) null : new Il2CppSystem.Nullable<T>(pointer);
    local = nullable;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 369428, RefRangeEnd = 369429, XrefRangeStart = 369402, XrefRangeEnd = 369428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryFetchHandle<THandle>(
    System.IntPtr source,
    out Il2CppArrayBase<THandle> target,
    int arrayLength)
    where THandle : Handle, new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryFetchHandle_Private_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_THandle_Int32_0<THandle>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppArrayBase<THandle> local = ref target;
    System.IntPtr num4 = zero;
    Il2CppArrayBase<THandle> il2CppArrayBase = num4 == System.IntPtr.Zero ? (Il2CppArrayBase<THandle>) null : new Il2CppArrayBase<THandle>(num4);
    local = il2CppArrayBase;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 369455, RefRangeEnd = 369456, XrefRangeStart = 369429, XrefRangeEnd = 369455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryFetch<T>(
    System.IntPtr source,
    out Il2CppArrayBase<T> target,
    int arrayLength,
    bool isElementAllocated)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isElementAllocated;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryFetch_Private_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_Int32_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppArrayBase<T> local = ref target;
    System.IntPtr num4 = zero;
    Il2CppArrayBase<T> il2CppArrayBase = num4 == System.IntPtr.Zero ? (Il2CppArrayBase<T>) null : new Il2CppArrayBase<T>(num4);
    local = il2CppArrayBase;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369456, XrefRangeEnd = 369468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryFetch(System.IntPtr source, out string target)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryFetch_Private_Static_Boolean_IntPtr_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    target = IL2CPP.Il2CppStringToManaged(zero);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 369470, RefRangeEnd = 369471, XrefRangeStart = 369468, XrefRangeEnd = 369470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvert<THandle>(System.IntPtr source, out THandle target) where THandle : Handle, new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    THandle& local1;
    if (!typeof (THandle).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local1 = ref (*(THandle*) &zero);
    }
    else
      local1 = ref target;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryConvert_Private_Static_Boolean_IntPtr_byref_THandle_0<THandle>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    if (!typeof (THandle).IsValueType)
    {
      ref THandle local2 = ref target;
      System.IntPtr num4 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num4 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<THandle>(num4, false, false);
      local2 = (THandle) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 369481, RefRangeEnd = 369482, XrefRangeStart = 369471, XrefRangeEnd = 369481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvert<TSource, TTarget>(TSource source, out TTarget target) where TTarget : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    TSource& local1;
    if (!typeof (TSource).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TSource> local2 = (object) source;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TSource&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TSource&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref source;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    TTarget& local3;
    if (!typeof (TTarget).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local3 = ref (*(TTarget*) &zero);
    }
    else
      local3 = ref target;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local3;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryConvert_Internal_Static_Boolean_TSource_byref_TTarget_0<TSource, TTarget>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    if (!typeof (TTarget).IsValueType)
    {
      ref TTarget local4 = ref target;
      System.IntPtr num4 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num4 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TTarget>(num4, false, false);
      local4 = (TTarget) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 369482, RefRangeEnd = 369484, XrefRangeStart = 369482, XrefRangeEnd = 369482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvert(Handle source, out System.IntPtr target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref target;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Handle_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369484, XrefRangeEnd = 369492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvert(Il2CppStructArray<byte> source, out string target)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Il2CppStructArray_1_Byte_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    target = IL2CPP.Il2CppStringToManaged(zero);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 369503, RefRangeEnd = 369507, XrefRangeStart = 369492, XrefRangeEnd = 369503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvert(
    string source,
    out Il2CppStructArray<byte> target,
    int length)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(source);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_String_byref_Il2CppStructArray_1_Byte_Int32_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppStructArray<byte> local = ref target;
    System.IntPtr num4 = zero;
    Il2CppStructArray<byte> il2CppStructArray = num4 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(num4);
    local = il2CppStructArray;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369507, XrefRangeEnd = 369512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvert(string source, out Il2CppStructArray<byte> target)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(source);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_String_byref_Il2CppStructArray_1_Byte_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppStructArray<byte> local = ref target;
    System.IntPtr num4 = zero;
    Il2CppStructArray<byte> il2CppStructArray = num4 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(num4);
    local = il2CppStructArray;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  public static unsafe bool TryConvert<T>(Il2CppArrayBase<T> source, out int target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref target;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryConvert_Private_Static_Boolean_Il2CppArrayBase_1_T_byref_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 369516, RefRangeEnd = 369517, XrefRangeStart = 369512, XrefRangeEnd = 369516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvert<T>(Il2CppArrayBase<T> source, out uint target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref target;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryConvert_Private_Static_Boolean_Il2CppArrayBase_1_T_byref_UInt32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 369531, RefRangeEnd = 369532, XrefRangeStart = 369517, XrefRangeEnd = 369531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvert<TSource, TTarget>(
    Il2CppArrayBase<TSource> source,
    out Il2CppArrayBase<TTarget> target)
    where TTarget : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryConvert_Internal_Static_Boolean_Il2CppArrayBase_1_TSource_byref_Il2CppArrayBase_1_TTarget_0<TSource, TTarget>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppArrayBase<TTarget> local = ref target;
    System.IntPtr num4 = zero;
    Il2CppArrayBase<TTarget> il2CppArrayBase = num4 == System.IntPtr.Zero ? (Il2CppArrayBase<TTarget>) null : new Il2CppArrayBase<TTarget>(num4);
    local = il2CppArrayBase;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 369532, RefRangeEnd = 369533, XrefRangeStart = 369532, XrefRangeEnd = 369532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvert(int source, out bool target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &source;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref target;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Int32_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool TryConvert(bool source, out int target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &source;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref target;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Boolean_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369533, XrefRangeEnd = 369549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvert(Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> source, out long target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) source));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref target;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Nullable_1_DateTimeOffset_byref_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369549, XrefRangeEnd = 369562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvert(long source, out Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> target)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = (System.IntPtr) &source;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Int64_byref_Nullable_1_DateTimeOffset_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> local = ref target;
    System.IntPtr pointer = zero;
    Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>) null : new Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>(pointer);
    local = nullable;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 369573, RefRangeEnd = 369575, XrefRangeStart = 369562, XrefRangeEnd = 369573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CanRemoveCallback<TCallbackInfo>(
    System.IntPtr clientDataAddress,
    TCallbackInfo callbackInfo)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &clientDataAddress;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TCallbackInfo& local1;
    if (!typeof (TCallbackInfo).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TCallbackInfo> local2 = (object) callbackInfo;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TCallbackInfo&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TCallbackInfo&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref callbackInfo;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_CanRemoveCallback_Private_Static_Boolean_IntPtr_TCallbackInfo_0<TCallbackInfo>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369575, XrefRangeEnd = 369603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryGetAndRemoveCallback<TCallback, TCallbackInfo>(
    System.IntPtr clientDataAddress,
    TCallbackInfo callbackInfo,
    out TCallback callback)
    where TCallback : class
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &clientDataAddress;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TCallbackInfo& local1;
    if (!typeof (TCallbackInfo).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TCallbackInfo> local2 = (object) callbackInfo;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TCallbackInfo&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TCallbackInfo&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref callbackInfo;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    TCallback& local3;
    if (!typeof (TCallback).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local3 = ref (*(TCallback*) &zero);
    }
    else
      local3 = ref callback;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local3;
    System.IntPtr num3;
    System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryGetAndRemoveCallback_Private_Static_Boolean_IntPtr_TCallbackInfo_byref_TCallback_0<TCallback, TCallbackInfo>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    if (!typeof (TCallback).IsValueType)
    {
      ref TCallback local4 = ref callback;
      System.IntPtr num5 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num5 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TCallback>(num5, false, false);
      local4 = (TCallback) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num4);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 369621, RefRangeEnd = 369622, XrefRangeStart = 369603, XrefRangeEnd = 369621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryGetStaticCallback<TCallback>(string key, out TCallback callback) where TCallback : class
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    TCallback& local1;
    if (!typeof (TCallback).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local1 = ref (*(TCallback*) &zero);
    }
    else
      local1 = ref callback;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryGetStaticCallback_Internal_Static_Boolean_String_byref_TCallback_0<TCallback>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    if (!typeof (TCallback).IsValueType)
    {
      ref TCallback local2 = ref callback;
      System.IntPtr num4 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num4 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TCallback>(num4, false, false);
      local2 = (TCallback) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369622, XrefRangeEnd = 369655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryGetStructCallback<TCallback>(
    System.IntPtr clientDataAddress,
    out TCallback structCallback)
    where TCallback : class
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &clientDataAddress;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    TCallback& local1;
    if (!typeof (TCallback).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local1 = ref (*(TCallback*) &zero);
    }
    else
      local1 = ref structCallback;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryGetStructCallback_Private_Static_Boolean_IntPtr_byref_TCallback_0<TCallback>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    if (!typeof (TCallback).IsValueType)
    {
      ref TCallback local2 = ref structCallback;
      System.IntPtr num4 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num4 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TCallback>(num4, false, false);
      local2 = (TCallback) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  public static void AddCallback(
    ref System.IntPtr clientDataAddress,
    Il2CppSystem.Object clientData,
    Il2CppSystem.Delegate publicDelegate,
    Il2CppSystem.Delegate privateDelegate,
    params Il2CppSystem.Delegate[] structDelegates)
  {
    Helper.AddCallback(ref clientDataAddress, clientData, publicDelegate, privateDelegate, new Il2CppReferenceArray<Il2CppSystem.Delegate>(structDelegates));
  }

  public Helper(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Dictionary<System.IntPtr, Helper.Allocation> s_Allocations
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Helper.NativeFieldInfoPtr_s_Allocations, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Dictionary<System.IntPtr, Helper.Allocation>) null : Il2CppObjectPool.Get<Dictionary<System.IntPtr, Helper.Allocation>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Helper.NativeFieldInfoPtr_s_Allocations, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<System.IntPtr, Helper.DelegateHolder> s_Callbacks
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Helper.NativeFieldInfoPtr_s_Callbacks, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Dictionary<System.IntPtr, Helper.DelegateHolder>) null : Il2CppObjectPool.Get<Dictionary<System.IntPtr, Helper.DelegateHolder>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Helper.NativeFieldInfoPtr_s_Callbacks, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<string, Helper.DelegateHolder> s_StaticCallbacks
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Helper.NativeFieldInfoPtr_s_StaticCallbacks, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Dictionary<string, Helper.DelegateHolder>) null : Il2CppObjectPool.Get<Dictionary<string, Helper.DelegateHolder>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Helper.NativeFieldInfoPtr_s_StaticCallbacks, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class Allocation(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Size_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedData_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsCachedArrayElementAllocated_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Size_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Size_Private_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CachedData_Public_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CachedData_Private_set_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCachedArrayElementAllocated_Public_get_Nullable_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsCachedArrayElementAllocated_Private_set_Void_Nullable_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCachedData_Public_Void_Object_Nullable_1_Boolean_0;

    static Allocation()
    {
      Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Helper>.NativeClassPtr, nameof (Allocation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr);
      Helper.Allocation.NativeFieldInfoPtr__Size_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, "<Size>k__BackingField");
      Helper.Allocation.NativeFieldInfoPtr__CachedData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, "<CachedData>k__BackingField");
      Helper.Allocation.NativeFieldInfoPtr__IsCachedArrayElementAllocated_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, "<IsCachedArrayElementAllocated>k__BackingField");
      Helper.Allocation.NativeMethodInfoPtr_get_Size_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, 100663865);
      Helper.Allocation.NativeMethodInfoPtr_set_Size_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, 100663866);
      Helper.Allocation.NativeMethodInfoPtr_get_CachedData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, 100663867);
      Helper.Allocation.NativeMethodInfoPtr_set_CachedData_Private_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, 100663868);
      Helper.Allocation.NativeMethodInfoPtr_get_IsCachedArrayElementAllocated_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, 100663869);
      Helper.Allocation.NativeMethodInfoPtr_set_IsCachedArrayElementAllocated_Private_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, 100663870);
      Helper.Allocation.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, 100663871);
      Helper.Allocation.NativeMethodInfoPtr_SetCachedData_Public_Void_Object_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, 100663872 /*0x06000240*/);
    }

    public unsafe int Size
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.Allocation.NativeMethodInfoPtr_get_Size_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(Helper.Allocation.NativeMethodInfoPtr_set_Size_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe Il2CppSystem.Object CachedData
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.Allocation.NativeMethodInfoPtr_get_CachedData_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(Helper.Allocation.NativeMethodInfoPtr_set_CachedData_Private_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe Il2CppSystem.Nullable<bool> IsCachedArrayElementAllocated
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Helper.Allocation.NativeMethodInfoPtr_get_IsCachedArrayElementAllocated_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
        return new Il2CppSystem.Nullable<bool>(pointer);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(Helper.Allocation.NativeMethodInfoPtr_set_IsCachedArrayElementAllocated_Private_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Allocation(int size)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &size
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Helper.Allocation.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 364203, RefRangeEnd = 364206, XrefRangeStart = 364203, XrefRangeEnd = 364203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetCachedData(Il2CppSystem.Object data, Il2CppSystem.Nullable<bool> isCachedArrayElementAllocated = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) isCachedArrayElementAllocated));
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Helper.Allocation.NativeMethodInfoPtr_SetCachedData_Public_Void_Object_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int _Size_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.Allocation.NativeFieldInfoPtr__Size_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.Allocation.NativeFieldInfoPtr__Size_k__BackingField)) = value;
      }
    }

    public unsafe Il2CppSystem.Object _CachedData_k__BackingField
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.Allocation.NativeFieldInfoPtr__CachedData_k__BackingField));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Helper.Allocation.NativeFieldInfoPtr__CachedData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public Il2CppSystem.Nullable<bool> _IsCachedArrayElementAllocated_k__BackingField
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.Allocation.NativeFieldInfoPtr__IsCachedArrayElementAllocated_k__BackingField);
        return new Il2CppSystem.Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.Allocation.NativeFieldInfoPtr__IsCachedArrayElementAllocated_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  public class DelegateHolder : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Public_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Private_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__StructDelegates_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__NotificationId_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Public_Public_get_Delegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Public_Private_set_Void_Delegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Private_Public_get_Delegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Private_Private_set_Void_Delegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StructDelegates_Public_get_Il2CppReferenceArray_1_Delegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_StructDelegates_Private_set_Void_Il2CppReferenceArray_1_Delegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NotificationId_Public_get_Nullable_1_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_NotificationId_Public_set_Void_Nullable_1_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Delegate_Delegate_Il2CppReferenceArray_1_Delegate_0;

    static DelegateHolder()
    {
      Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Helper>.NativeClassPtr, nameof (DelegateHolder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr);
      Helper.DelegateHolder.NativeFieldInfoPtr__Public_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, "<Public>k__BackingField");
      Helper.DelegateHolder.NativeFieldInfoPtr__Private_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, "<Private>k__BackingField");
      Helper.DelegateHolder.NativeFieldInfoPtr__StructDelegates_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, "<StructDelegates>k__BackingField");
      Helper.DelegateHolder.NativeFieldInfoPtr__NotificationId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, "<NotificationId>k__BackingField");
      Helper.DelegateHolder.NativeMethodInfoPtr_get_Public_Public_get_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, 100663873);
      Helper.DelegateHolder.NativeMethodInfoPtr_set_Public_Private_set_Void_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, 100663874);
      Helper.DelegateHolder.NativeMethodInfoPtr_get_Private_Public_get_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, 100663875);
      Helper.DelegateHolder.NativeMethodInfoPtr_set_Private_Private_set_Void_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, 100663876);
      Helper.DelegateHolder.NativeMethodInfoPtr_get_StructDelegates_Public_get_Il2CppReferenceArray_1_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, 100663877);
      Helper.DelegateHolder.NativeMethodInfoPtr_set_StructDelegates_Private_set_Void_Il2CppReferenceArray_1_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, 100663878);
      Helper.DelegateHolder.NativeMethodInfoPtr_get_NotificationId_Public_get_Nullable_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, 100663879);
      Helper.DelegateHolder.NativeMethodInfoPtr_set_NotificationId_Public_set_Void_Nullable_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, 100663880);
      Helper.DelegateHolder.NativeMethodInfoPtr__ctor_Public_Void_Delegate_Delegate_Il2CppReferenceArray_1_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, 100663881);
    }

    public unsafe Il2CppSystem.Delegate Public
    {
      [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.DelegateHolder.NativeMethodInfoPtr_get_Public_Public_get_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Delegate) null : Il2CppObjectPool.Get<Il2CppSystem.Delegate>(num3);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(Helper.DelegateHolder.NativeMethodInfoPtr_set_Public_Private_set_Void_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe Il2CppSystem.Delegate Private
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.DelegateHolder.NativeMethodInfoPtr_get_Private_Public_get_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Delegate) null : Il2CppObjectPool.Get<Il2CppSystem.Delegate>(num3);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(Helper.DelegateHolder.NativeMethodInfoPtr_set_Private_Private_set_Void_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe Il2CppReferenceArray<Il2CppSystem.Delegate> StructDelegates
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.DelegateHolder.NativeMethodInfoPtr_get_StructDelegates_Public_get_Il2CppReferenceArray_1_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Delegate>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Delegate>>(num3);
      }
      [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(Helper.DelegateHolder.NativeMethodInfoPtr_set_StructDelegates_Private_set_Void_Il2CppReferenceArray_1_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe Il2CppSystem.Nullable<ulong> NotificationId
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Helper.DelegateHolder.NativeMethodInfoPtr_get_NotificationId_Public_get_Nullable_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
        return new Il2CppSystem.Nullable<ulong>(pointer);
      }
      [CallerCount(6), CachedScanResults(RefRangeStart = 79557, RefRangeEnd = 79563, XrefRangeStart = 79557, XrefRangeEnd = 79563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(Helper.DelegateHolder.NativeMethodInfoPtr_set_NotificationId_Public_set_Void_Nullable_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 114557, RefRangeEnd = 114562, XrefRangeStart = 114557, XrefRangeEnd = 114562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DelegateHolder(
      Il2CppSystem.Delegate publicDelegate,
      Il2CppSystem.Delegate privateDelegate,
      [Optional] Il2CppReferenceArray<Il2CppSystem.Delegate> structDelegates)
    {
      if (structDelegates == null)
        structDelegates = new Il2CppReferenceArray<Il2CppSystem.Delegate>(0L);
      // ISSUE: explicit constructor call
      this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr));
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) publicDelegate);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) privateDelegate);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) structDelegates);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Helper.DelegateHolder.NativeMethodInfoPtr__ctor_Public_Void_Delegate_Delegate_Il2CppReferenceArray_1_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public DelegateHolder(
      Il2CppSystem.Delegate publicDelegate,
      Il2CppSystem.Delegate privateDelegate,
      params Il2CppSystem.Delegate[] structDelegates)
      : this(publicDelegate, privateDelegate, new Il2CppReferenceArray<Il2CppSystem.Delegate>(structDelegates))
    {
    }

    public DelegateHolder(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppSystem.Delegate _Public_k__BackingField
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.DelegateHolder.NativeFieldInfoPtr__Public_k__BackingField));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Delegate) null : Il2CppObjectPool.Get<Il2CppSystem.Delegate>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Helper.DelegateHolder.NativeFieldInfoPtr__Public_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Delegate _Private_k__BackingField
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.DelegateHolder.NativeFieldInfoPtr__Private_k__BackingField));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Delegate) null : Il2CppObjectPool.Get<Il2CppSystem.Delegate>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Helper.DelegateHolder.NativeFieldInfoPtr__Private_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<Il2CppSystem.Delegate> _StructDelegates_k__BackingField
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.DelegateHolder.NativeFieldInfoPtr__StructDelegates_k__BackingField));
        return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Delegate>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Delegate>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Helper.DelegateHolder.NativeFieldInfoPtr__StructDelegates_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public Il2CppSystem.Nullable<ulong> _NotificationId_k__BackingField
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.DelegateHolder.NativeFieldInfoPtr__NotificationId_k__BackingField);
        return new Il2CppSystem.Nullable<ulong>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<ulong>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.DelegateHolder.NativeFieldInfoPtr__NotificationId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<ulong>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("Epic.OnlineServices.Helper+<>c__99`1")]
  [Serializable]
  public sealed class __c__99<TCallback>(System.IntPtr pointer) : Il2CppSystem.Object(pointer) where TCallback : class
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__99_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryGetStructCallback_b__99_0_Internal_Boolean_Delegate_0;

    static __c__99()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<Helper.__c__99<TCallback>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Helper>.NativeClassPtr, "<>c__99`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallback>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Helper.__c__99<TCallback>>.NativeClassPtr);
      Helper.__c__99<TCallback>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.__c__99<TCallback>>.NativeClassPtr, "<>9");
      Helper.__c__99<TCallback>.NativeFieldInfoPtr___9__99_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.__c__99<TCallback>>.NativeClassPtr, "<>9__99_0");
      Helper.__c__99<TCallback>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.__c__99<TCallback>>.NativeClassPtr, 100663883);
      Helper.__c__99<TCallback>.NativeMethodInfoPtr__TryGetStructCallback_b__99_0_Internal_Boolean_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.__c__99<TCallback>>.NativeClassPtr, 100663884);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__99()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Helper.__c__99<TCallback>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Helper.__c__99<TCallback>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364206, XrefRangeEnd = 364212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _TryGetStructCallback_b__99_0(Il2CppSystem.Delegate delegat)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) delegat)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.__c__99<TCallback>.NativeMethodInfoPtr__TryGetStructCallback_b__99_0_Internal_Boolean_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe Helper.__c__99<TCallback> __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(Helper.__c__99<TCallback>.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Helper.__c__99<TCallback>) null : Il2CppObjectPool.Get<Helper.__c__99<TCallback>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Helper.__c__99<TCallback>.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Il2CppSystem.Delegate, bool> __9__99_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(Helper.__c__99<TCallback>.NativeFieldInfoPtr___9__99_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.Delegate, bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppSystem.Delegate, bool>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Helper.__c__99<TCallback>.NativeFieldInfoPtr___9__99_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Epic.OnlineServices.Helper+<>c__DisplayClass69_0")]
  public sealed class __c__DisplayClass69_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_notificationId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryRemoveCallbackByNotificationId_b__0_Internal_Boolean_KeyValuePair_2_IntPtr_DelegateHolder_0;

    static __c__DisplayClass69_0()
    {
      Il2CppClassPointerStore<Helper.__c__DisplayClass69_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Helper>.NativeClassPtr, "<>c__DisplayClass69_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Helper.__c__DisplayClass69_0>.NativeClassPtr);
      Helper.__c__DisplayClass69_0.NativeFieldInfoPtr_notificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.__c__DisplayClass69_0>.NativeClassPtr, nameof (notificationId));
      Helper.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.__c__DisplayClass69_0>.NativeClassPtr, 100663885);
      Helper.__c__DisplayClass69_0.NativeMethodInfoPtr__TryRemoveCallbackByNotificationId_b__0_Internal_Boolean_KeyValuePair_2_IntPtr_DelegateHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.__c__DisplayClass69_0>.NativeClassPtr, 100663886);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass69_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Helper.__c__DisplayClass69_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Helper.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364212, XrefRangeEnd = 364215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _TryRemoveCallbackByNotificationId_b__0(
      KeyValuePair<System.IntPtr, Helper.DelegateHolder> pair)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) pair))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.__c__DisplayClass69_0.NativeMethodInfoPtr__TryRemoveCallbackByNotificationId_b__0_Internal_Boolean_KeyValuePair_2_IntPtr_DelegateHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe ulong notificationId
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.__c__DisplayClass69_0.NativeFieldInfoPtr_notificationId));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.__c__DisplayClass69_0.NativeFieldInfoPtr_notificationId)) = value;
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_Il2CppArrayBase_1_T_byref_UInt32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Il2CppArrayBase_1_T_byref_UInt32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_T_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_TSource_byref_TTarget_0<TSource, TTarget>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_TSource_byref_TTarget_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTarget>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_Int32_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_Int32_Boolean_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_UInt32_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_UInt32_Boolean_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_UInt32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_UInt32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGetHandle_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_THandle_UInt32_0<THandle>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGetHandle_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_THandle_UInt32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<THandle>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_Il2CppArrayBase_1_TSource_byref_Il2CppArrayBase_1_TTarget_0<TSource, TTarget>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Il2CppArrayBase_1_TSource_byref_Il2CppArrayBase_1_TTarget_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTarget>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_TTarget_Int32_0<TSource, TTarget>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_TTarget_Int32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTarget>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_TTarget_UInt32_0<TSource, TTarget>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_TTarget_UInt32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTarget>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Nullable_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Nullable_1_T_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_T_byref_T_TEnum_TEnum_0<T, TEnum>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_T_byref_T_TEnum_TEnum_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_ISettable_byref_TTarget_TEnum_TEnum_0<TTarget, TEnum>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_ISettable_byref_TTarget_TEnum_TEnum_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTarget>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_Int32_byref_Nullable_1_Boolean_TEnum_TEnum_0<TEnum>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_Int32_byref_Nullable_1_Boolean_TEnum_TEnum_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_T_byref_Nullable_1_T_TEnum_TEnum_0<T, TEnum>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_T_byref_Nullable_1_T_TEnum_TEnum_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_T_TEnum_TEnum_0<T, TEnum>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_T_TEnum_TEnum_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Nullable_1_IntPtr_TEnum_TEnum_0<TEnum>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_Nullable_1_IntPtr_TEnum_TEnum_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_String_TEnum_TEnum_0<TEnum>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_String_TEnum_TEnum_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_TPublic_0<TInternal, TPublic>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_TPublic_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInternal>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPublic>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_TCallbackInfo_byref_IntPtr_0<TCallbackInfoInternal, TCallbackInfo>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalGet_Internal_Static_Boolean_IntPtr_byref_TCallbackInfo_byref_IntPtr_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallbackInfoInternal>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallbackInfo>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_T_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_T_T_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_TTarget_Object_0<TTarget>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_TTarget_Object_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTarget>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Nullable_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Nullable_1_T_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_byref_Int32_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_byref_Int32_Boolean_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_byref_UInt32_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_byref_UInt32_Boolean_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_byref_UInt32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_byref_UInt32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_T_T_byref_TEnum_TEnum_IDisposable_0<T, TEnum>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_T_T_byref_TEnum_TEnum_IDisposable_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_TTarget_ISettable_byref_TEnum_TEnum_IDisposable_0<TTarget, TEnum>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_TTarget_ISettable_byref_TEnum_TEnum_IDisposable_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTarget>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_T_Nullable_1_T_byref_TEnum_TEnum_IDisposable_0<T, TEnum>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_T_Nullable_1_T_byref_TEnum_TEnum_IDisposable_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Handle_byref_TEnum_TEnum_IDisposable_0<TEnum>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Handle_byref_TEnum_TEnum_IDisposable_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_String_byref_TEnum_TEnum_IDisposable_0<TEnum>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_String_byref_TEnum_TEnum_IDisposable_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_Int32_Nullable_1_Boolean_byref_TEnum_TEnum_IDisposable_0<TEnum>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_Int32_Nullable_1_Boolean_byref_TEnum_TEnum_IDisposable_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_TPublic_0<TInternal, TPublic>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_TPublic_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInternal>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPublic>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_Int32_0<TInternal, TPublic>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_Int32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInternal>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPublic>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_UInt32_0<TInternal, TPublic>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_UInt32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInternal>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPublic>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_Int32_Boolean_0<TInternal, TPublic>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_Int32_Boolean_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInternal>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPublic>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_UInt32_Boolean_0<TInternal, TPublic>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalSet_Internal_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_TPublic_byref_UInt32_Boolean_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInternal>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPublic>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalDispose_Internal_Static_Boolean_byref_TDisposable_0<TDisposable>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalDispose_Internal_Static_Boolean_byref_TDisposable_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDisposable>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryMarshalDispose_Internal_Static_Boolean_byref_IntPtr_TEnum_TEnum_0<TEnum>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryMarshalDispose_Internal_Static_Boolean_byref_IntPtr_TEnum_TEnum_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetDefault_Internal_Static_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_GetDefault_Internal_Static_T_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryGetAndRemoveCallback_Internal_Static_Boolean_IntPtr_byref_TCallback_byref_TCallbackInfo_0<TCallback, TCallbackInfoInternal, TCallbackInfo>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryGetAndRemoveCallback_Internal_Static_Boolean_IntPtr_byref_TCallback_byref_TCallbackInfo_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallback>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallbackInfoInternal>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallbackInfo>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryGetStructCallback_Internal_Static_Boolean_IntPtr_byref_TDelegate_byref_TCallbackInfo_0<TDelegate, TCallbackInfoInternal, TCallbackInfo>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryGetStructCallback_Internal_Static_Boolean_IntPtr_byref_TDelegate_byref_TCallbackInfo_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallbackInfoInternal>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallbackInfo>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryAllocate_Private_Static_Boolean_byref_IntPtr_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryAllocate_Private_Static_Boolean_byref_IntPtr_T_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryAllocate_Private_Static_Boolean_byref_IntPtr_Nullable_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryAllocate_Private_Static_Boolean_byref_IntPtr_Nullable_1_T_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryAllocate_Private_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryAllocate_Private_Static_Boolean_byref_IntPtr_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryAllocateCacheOnly_Private_Static_Boolean_byref_IntPtr_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryAllocateCacheOnly_Private_Static_Boolean_byref_IntPtr_T_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryFetch_Private_Static_Boolean_IntPtr_byref_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryFetch_Private_Static_Boolean_IntPtr_byref_T_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryFetch_Private_Static_Boolean_IntPtr_byref_Nullable_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryFetch_Private_Static_Boolean_IntPtr_byref_Nullable_1_T_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryFetchHandle_Private_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_THandle_Int32_0<THandle>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryFetchHandle_Private_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_THandle_Int32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<THandle>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryFetch_Private_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_Int32_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryFetch_Private_Static_Boolean_IntPtr_byref_Il2CppArrayBase_1_T_Int32_Boolean_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryConvert_Private_Static_Boolean_IntPtr_byref_THandle_0<THandle>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_IntPtr_byref_THandle_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<THandle>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryConvert_Internal_Static_Boolean_TSource_byref_TTarget_0<TSource, TTarget>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryConvert_Internal_Static_Boolean_TSource_byref_TTarget_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTarget>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryConvert_Private_Static_Boolean_Il2CppArrayBase_1_T_byref_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Il2CppArrayBase_1_T_byref_Int32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryConvert_Private_Static_Boolean_Il2CppArrayBase_1_T_byref_UInt32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Il2CppArrayBase_1_T_byref_UInt32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryConvert_Internal_Static_Boolean_Il2CppArrayBase_1_TSource_byref_Il2CppArrayBase_1_TTarget_0<TSource, TTarget>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryConvert_Internal_Static_Boolean_Il2CppArrayBase_1_TSource_byref_Il2CppArrayBase_1_TTarget_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTarget>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_CanRemoveCallback_Private_Static_Boolean_IntPtr_TCallbackInfo_0<TCallbackInfo>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_CanRemoveCallback_Private_Static_Boolean_IntPtr_TCallbackInfo_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallbackInfo>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryGetAndRemoveCallback_Private_Static_Boolean_IntPtr_TCallbackInfo_byref_TCallback_0<TCallback, TCallbackInfo>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryGetAndRemoveCallback_Private_Static_Boolean_IntPtr_TCallbackInfo_byref_TCallback_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallback>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallbackInfo>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryGetStaticCallback_Internal_Static_Boolean_String_byref_TCallback_0<TCallback>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryGetStaticCallback_Internal_Static_Boolean_String_byref_TCallback_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallback>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryGetStructCallback_Private_Static_Boolean_IntPtr_byref_TCallback_0<TCallback>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryGetStructCallback_Private_Static_Boolean_IntPtr_byref_TCallback_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallback>.NativeClassPtr))
    }))));
  }
}
