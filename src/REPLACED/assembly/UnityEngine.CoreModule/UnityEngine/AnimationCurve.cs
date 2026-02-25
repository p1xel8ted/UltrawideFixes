// Decompiled with JetBrains decompiler
// Type: UnityEngine.AnimationCurve
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

public class AnimationCurve : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RequiresNativeCleanup;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Il2CppStructArray_1_Keyframe_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CopyFrom_Private_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_keys_Public_get_Il2CppStructArray_1_Keyframe_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_keys_Public_set_Void_Il2CppStructArray_1_Keyframe_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddKey_Public_Int32_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddKey_Public_Int32_Keyframe_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddKey_Internal_Private_Int32_Keyframe_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveKey_Public_Int32_Int32_Keyframe_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearKeys_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveKey_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_Keyframe_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_length_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetKeys_Private_Void_Il2CppStructArray_1_Keyframe_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetKey_Private_Keyframe_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetKeys_Private_Il2CppStructArray_1_Keyframe_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SmoothTangents_Public_Void_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Linear_Public_Static_AnimationCurve_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EaseInOut_Public_Static_AnimationCurve_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_preWrapMode_Public_get_WrapMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_preWrapMode_Public_set_Void_WrapMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_postWrapMode_Public_get_WrapMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_postWrapMode_Public_set_Void_WrapMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Keyframe_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationCurve_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_AnimationCurve_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Create_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Equals_Injected_Private_Static_Boolean_IntPtr_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CopyFrom_Injected_Private_Static_Void_IntPtr_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Injected_Private_Static_Single_IntPtr_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddKey_Injected_Private_Static_Int32_IntPtr_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddKey_Internal_Injected_Private_Static_Int32_IntPtr_byref_Keyframe_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveKey_Injected_Private_Static_Int32_IntPtr_Int32_byref_Keyframe_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearKeys_Injected_Private_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveKey_Injected_Private_Static_Void_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_length_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetKeys_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetKey_Injected_Private_Static_Void_IntPtr_Int32_byref_Keyframe_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetKeys_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SmoothTangents_Injected_Private_Static_Void_IntPtr_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_preWrapMode_Injected_Private_Static_WrapMode_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_preWrapMode_Injected_Private_Static_Void_IntPtr_WrapMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_postWrapMode_Injected_Private_Static_WrapMode_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_postWrapMode_Injected_Private_Static_Void_IntPtr_WrapMode_0;

  static AnimationCurve()
  {
    Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (AnimationCurve));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr);
    AnimationCurve.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, nameof (m_Ptr));
    AnimationCurve.NativeFieldInfoPtr_m_RequiresNativeCleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, nameof (m_RequiresNativeCleanup));
    AnimationCurve.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663800);
    AnimationCurve.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663801);
    AnimationCurve.NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663802);
    AnimationCurve.NativeMethodInfoPtr_Internal_CopyFrom_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663803);
    AnimationCurve.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663804);
    AnimationCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663805);
    AnimationCurve.NativeMethodInfoPtr_get_keys_Public_get_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663806);
    AnimationCurve.NativeMethodInfoPtr_set_keys_Public_set_Void_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663807);
    AnimationCurve.NativeMethodInfoPtr_AddKey_Public_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663808 /*0x06000200*/);
    AnimationCurve.NativeMethodInfoPtr_AddKey_Public_Int32_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663809 /*0x06000201*/);
    AnimationCurve.NativeMethodInfoPtr_AddKey_Internal_Private_Int32_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663810 /*0x06000202*/);
    AnimationCurve.NativeMethodInfoPtr_MoveKey_Public_Int32_Int32_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663811 /*0x06000203*/);
    AnimationCurve.NativeMethodInfoPtr_ClearKeys_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663812 /*0x06000204*/);
    AnimationCurve.NativeMethodInfoPtr_RemoveKey_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663813 /*0x06000205*/);
    AnimationCurve.NativeMethodInfoPtr_get_Item_Public_get_Keyframe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663814 /*0x06000206*/);
    AnimationCurve.NativeMethodInfoPtr_get_length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663815 /*0x06000207*/);
    AnimationCurve.NativeMethodInfoPtr_SetKeys_Private_Void_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663816 /*0x06000208*/);
    AnimationCurve.NativeMethodInfoPtr_GetKey_Private_Keyframe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663817 /*0x06000209*/);
    AnimationCurve.NativeMethodInfoPtr_GetKeys_Private_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663818 /*0x0600020A*/);
    AnimationCurve.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663819 /*0x0600020B*/);
    AnimationCurve.NativeMethodInfoPtr_SmoothTangents_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663820 /*0x0600020C*/);
    AnimationCurve.NativeMethodInfoPtr_Linear_Public_Static_AnimationCurve_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663821 /*0x0600020D*/);
    AnimationCurve.NativeMethodInfoPtr_EaseInOut_Public_Static_AnimationCurve_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663822 /*0x0600020E*/);
    AnimationCurve.NativeMethodInfoPtr_get_preWrapMode_Public_get_WrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663823 /*0x0600020F*/);
    AnimationCurve.NativeMethodInfoPtr_set_preWrapMode_Public_set_Void_WrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663824 /*0x06000210*/);
    AnimationCurve.NativeMethodInfoPtr_get_postWrapMode_Public_get_WrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663825);
    AnimationCurve.NativeMethodInfoPtr_set_postWrapMode_Public_set_Void_WrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663826);
    AnimationCurve.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663827);
    AnimationCurve.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663828);
    AnimationCurve.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663829);
    AnimationCurve.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663830);
    AnimationCurve.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663831);
    AnimationCurve.NativeMethodInfoPtr_CopyFrom_Public_Void_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663832);
    AnimationCurve.NativeMethodInfoPtr_Internal_Create_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663833);
    AnimationCurve.NativeMethodInfoPtr_Internal_Equals_Injected_Private_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663834);
    AnimationCurve.NativeMethodInfoPtr_Internal_CopyFrom_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663835);
    AnimationCurve.NativeMethodInfoPtr_Evaluate_Injected_Private_Static_Single_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663836);
    AnimationCurve.NativeMethodInfoPtr_AddKey_Injected_Private_Static_Int32_IntPtr_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663837);
    AnimationCurve.NativeMethodInfoPtr_AddKey_Internal_Injected_Private_Static_Int32_IntPtr_byref_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663838);
    AnimationCurve.NativeMethodInfoPtr_MoveKey_Injected_Private_Static_Int32_IntPtr_Int32_byref_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663839);
    AnimationCurve.NativeMethodInfoPtr_ClearKeys_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663840 /*0x06000220*/);
    AnimationCurve.NativeMethodInfoPtr_RemoveKey_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663841);
    AnimationCurve.NativeMethodInfoPtr_get_length_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663842);
    AnimationCurve.NativeMethodInfoPtr_SetKeys_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663843);
    AnimationCurve.NativeMethodInfoPtr_GetKey_Injected_Private_Static_Void_IntPtr_Int32_byref_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663844);
    AnimationCurve.NativeMethodInfoPtr_GetKeys_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663845);
    AnimationCurve.NativeMethodInfoPtr_GetHashCode_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663846);
    AnimationCurve.NativeMethodInfoPtr_SmoothTangents_Injected_Private_Static_Void_IntPtr_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663847);
    AnimationCurve.NativeMethodInfoPtr_get_preWrapMode_Injected_Private_Static_WrapMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663848);
    AnimationCurve.NativeMethodInfoPtr_set_preWrapMode_Injected_Private_Static_Void_IntPtr_WrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663849);
    AnimationCurve.NativeMethodInfoPtr_get_postWrapMode_Injected_Private_Static_WrapMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663850);
    AnimationCurve.NativeMethodInfoPtr_set_postWrapMode_Injected_Private_Static_Void_IntPtr_WrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663851);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416236, XrefRangeEnd = 416238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_Destroy(System.IntPtr ptr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &ptr
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 416247, RefRangeEnd = 416251, XrefRangeStart = 416238, XrefRangeEnd = 416247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr Internal_Create(Il2CppStructArray<Keyframe> keys)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keys)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Il2CppStructArray_1_Keyframe_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416251, XrefRangeEnd = 416255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Internal_Equals(System.IntPtr other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416255, XrefRangeEnd = 416259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Internal_CopyFrom(System.IntPtr other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Internal_CopyFrom_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416259, XrefRangeEnd = 416264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void Finalize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnimationCurve.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(94)]
  [CachedScanResults(RefRangeStart = 416268, RefRangeEnd = 416362, XrefRangeStart = 416264, XrefRangeEnd = 416268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float Evaluate(float time)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &time
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Il2CppStructArray<Keyframe> keys
  {
    [CallerCount(75), CachedScanResults(RefRangeStart = 416363, RefRangeEnd = 416438, XrefRangeStart = 416362, XrefRangeEnd = 416363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_get_keys_Public_get_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStructArray<Keyframe>) null : Il2CppObjectPool.Get<Il2CppStructArray<Keyframe>>(num3);
    }
    [CallerCount(43), CachedScanResults(RefRangeStart = 416448, RefRangeEnd = 416491, XrefRangeStart = 416438, XrefRangeEnd = 416448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_set_keys_Public_set_Void_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(52)]
  [CachedScanResults(RefRangeStart = 416495, RefRangeEnd = 416547, XrefRangeStart = 416491, XrefRangeEnd = 416495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int AddKey(float time, float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &time;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_AddKey_Public_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 416550, RefRangeEnd = 416556, XrefRangeStart = 416547, XrefRangeEnd = 416550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int AddKey(Keyframe key)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &key
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_AddKey_Public_Int32_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416556, XrefRangeEnd = 416559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int AddKey_Internal(Keyframe key)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &key
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_AddKey_Internal_Private_Int32_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 416562, RefRangeEnd = 416563, XrefRangeStart = 416559, XrefRangeEnd = 416562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int MoveKey(int index, Keyframe key)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &key;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_MoveKey_Public_Int32_Int32_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 416567, RefRangeEnd = 416569, XrefRangeStart = 416563, XrefRangeEnd = 416567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearKeys()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_ClearKeys_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 416573, RefRangeEnd = 416575, XrefRangeStart = 416569, XrefRangeEnd = 416573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveKey(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_RemoveKey_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Keyframe this[int index]
  {
    [CallerCount(10), CachedScanResults(RefRangeStart = 416578, RefRangeEnd = 416588, XrefRangeStart = 416575, XrefRangeEnd = 416578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_get_Item_Public_get_Keyframe_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Keyframe*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int length
  {
    [CallerCount(42), CachedScanResults(RefRangeStart = 416592, RefRangeEnd = 416634, XrefRangeStart = 416588, XrefRangeEnd = 416592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_get_length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(43)]
  [CachedScanResults(RefRangeStart = 416448, RefRangeEnd = 416491, XrefRangeStart = 416448, XrefRangeEnd = 416491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetKeys(Il2CppStructArray<Keyframe> keys)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keys)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_SetKeys_Private_Void_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416634, XrefRangeEnd = 416637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Keyframe GetKey(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_GetKey_Private_Keyframe_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Keyframe*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 416644, RefRangeEnd = 416645, XrefRangeStart = 416637, XrefRangeEnd = 416644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppStructArray<Keyframe> GetKeys()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_GetKeys_Private_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStructArray<Keyframe>) null : Il2CppObjectPool.Get<Il2CppStructArray<Keyframe>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416645, XrefRangeEnd = 416649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnimationCurve.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 416653, RefRangeEnd = 416654, XrefRangeStart = 416649, XrefRangeEnd = 416653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SmoothTangents(int index, float weight)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &weight;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_SmoothTangents_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(17)]
  [CachedScanResults(RefRangeStart = 416665, RefRangeEnd = 416682, XrefRangeStart = 416654, XrefRangeEnd = 416665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AnimationCurve Linear(
    float timeStart,
    float valueStart,
    float timeEnd,
    float valueEnd)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &timeStart;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &valueStart;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &timeEnd;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &valueEnd;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Linear_Public_Static_AnimationCurve_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num3);
  }

  [CallerCount(19)]
  [CachedScanResults(RefRangeStart = 416693, RefRangeEnd = 416712, XrefRangeStart = 416682, XrefRangeEnd = 416693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AnimationCurve EaseInOut(
    float timeStart,
    float valueStart,
    float timeEnd,
    float valueEnd)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &timeStart;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &valueStart;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &timeEnd;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &valueEnd;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_EaseInOut_Public_Static_AnimationCurve_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num3);
  }

  public unsafe WrapMode preWrapMode
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 416716, RefRangeEnd = 416720, XrefRangeStart = 416712, XrefRangeEnd = 416716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_get_preWrapMode_Public_get_WrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(WrapMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 416724, RefRangeEnd = 416729, XrefRangeStart = 416720, XrefRangeEnd = 416724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_set_preWrapMode_Public_set_Void_WrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe WrapMode postWrapMode
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 416733, RefRangeEnd = 416737, XrefRangeStart = 416729, XrefRangeEnd = 416733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_get_postWrapMode_Public_get_WrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(WrapMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(7), CachedScanResults(RefRangeStart = 416741, RefRangeEnd = 416748, XrefRangeStart = 416737, XrefRangeEnd = 416741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_set_postWrapMode_Public_set_Void_WrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 416750, RefRangeEnd = 416773, XrefRangeStart = 416748, XrefRangeEnd = 416750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AnimationCurve([Optional] Il2CppStructArray<Keyframe> keys)
  {
    if (keys == null)
      keys = new Il2CppStructArray<Keyframe>(0L);
    // ISSUE: explicit constructor call
    this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr));
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keys)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(33)]
  [CachedScanResults(RefRangeStart = 416775, RefRangeEnd = 416808, XrefRangeStart = 416773, XrefRangeEnd = 416775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AnimationCurve()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 254372, RefRangeEnd = 254374, XrefRangeStart = 254372, XrefRangeEnd = 254374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AnimationCurve(System.IntPtr ptr, bool ownMemory)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &ptr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ownMemory;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416808, XrefRangeEnd = 416825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Equals(Il2CppSystem.Object o)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) o)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnimationCurve.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416825, XrefRangeEnd = 416828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(AnimationCurve other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 416832, RefRangeEnd = 416833, XrefRangeStart = 416828, XrefRangeEnd = 416832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CopyFrom(AnimationCurve other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_CopyFrom_Public_Void_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416833, XrefRangeEnd = 416835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr Internal_Create_Injected(ref ManagedSpanWrapper keys)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref keys
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Internal_Create_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416835, XrefRangeEnd = 416837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Internal_Equals_Injected(System.IntPtr _unity_self, System.IntPtr other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &other;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Internal_Equals_Injected_Private_Static_Boolean_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416837, XrefRangeEnd = 416839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_CopyFrom_Injected(System.IntPtr _unity_self, System.IntPtr other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &other;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Internal_CopyFrom_Injected_Private_Static_Void_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416839, XrefRangeEnd = 416841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Evaluate_Injected(System.IntPtr _unity_self, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Evaluate_Injected_Private_Static_Single_IntPtr_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416841, XrefRangeEnd = 416843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int AddKey_Injected(System.IntPtr _unity_self, float time, float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_AddKey_Injected_Private_Static_Int32_IntPtr_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416843, XrefRangeEnd = 416845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int AddKey_Internal_Injected(System.IntPtr _unity_self, [In] ref Keyframe key)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref key;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_AddKey_Internal_Injected_Private_Static_Int32_IntPtr_byref_Keyframe_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416845, XrefRangeEnd = 416847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int MoveKey_Injected(System.IntPtr _unity_self, int index, [In] ref Keyframe key)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref key;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_MoveKey_Injected_Private_Static_Int32_IntPtr_Int32_byref_Keyframe_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416847, XrefRangeEnd = 416849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ClearKeys_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_ClearKeys_Injected_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416849, XrefRangeEnd = 416851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RemoveKey_Injected(System.IntPtr _unity_self, int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_RemoveKey_Injected_Private_Static_Void_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416851, XrefRangeEnd = 416853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_length_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_get_length_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416853, XrefRangeEnd = 416855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetKeys_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper keys)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref keys;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_SetKeys_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416855, XrefRangeEnd = 416857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetKey_Injected(System.IntPtr _unity_self, int index, out Keyframe ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_GetKey_Injected_Private_Static_Void_IntPtr_Int32_byref_Keyframe_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416857, XrefRangeEnd = 416859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetKeys_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_GetKeys_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416859, XrefRangeEnd = 416861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetHashCode_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_GetHashCode_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416861, XrefRangeEnd = 416863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SmoothTangents_Injected(System.IntPtr _unity_self, int index, float weight)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &weight;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_SmoothTangents_Injected_Private_Static_Void_IntPtr_Int32_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416863, XrefRangeEnd = 416865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe WrapMode get_preWrapMode_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_get_preWrapMode_Injected_Private_Static_WrapMode_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(WrapMode*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416865, XrefRangeEnd = 416867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_preWrapMode_Injected(System.IntPtr _unity_self, WrapMode value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_set_preWrapMode_Injected_Private_Static_Void_IntPtr_WrapMode_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416867, XrefRangeEnd = 416869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe WrapMode get_postWrapMode_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_get_postWrapMode_Injected_Private_Static_WrapMode_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(WrapMode*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416869, XrefRangeEnd = 416871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_postWrapMode_Injected(System.IntPtr _unity_self, WrapMode value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_set_postWrapMode_Injected_Private_Static_Void_IntPtr_WrapMode_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public AnimationCurve(params Keyframe[] keys)
    : this(new Il2CppStructArray<Keyframe>(keys))
  {
  }

  public AnimationCurve(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe System.IntPtr m_Ptr
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCurve.NativeFieldInfoPtr_m_Ptr));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCurve.NativeFieldInfoPtr_m_Ptr)) = value;
    }
  }

  public unsafe bool m_RequiresNativeCleanup
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCurve.NativeFieldInfoPtr_m_RequiresNativeCleanup));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCurve.NativeFieldInfoPtr_m_RequiresNativeCleanup)) = value;
    }
  }

  public static AnimationCurve Constant(float timeStart, float timeEnd, float value)
  {
    return AnimationCurve.Linear(timeStart, value, timeEnd, value);
  }

  public static class BindingsMarshaller : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToManaged_Public_Static_AnimationCurve_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_AnimationCurve_0;

    static BindingsMarshaller()
    {
      Il2CppClassPointerStore<AnimationCurve.BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, nameof (BindingsMarshaller));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCurve.BindingsMarshaller>.NativeClassPtr);
      AnimationCurve.BindingsMarshaller.NativeMethodInfoPtr_ConvertToManaged_Public_Static_AnimationCurve_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve.BindingsMarshaller>.NativeClassPtr, 100663852);
      AnimationCurve.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve.BindingsMarshaller>.NativeClassPtr, 100663853);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 416232, RefRangeEnd = 416236, XrefRangeStart = 416228, XrefRangeEnd = 416232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AnimationCurve ConvertToManaged(System.IntPtr ptr)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &ptr
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.BindingsMarshaller.NativeMethodInfoPtr_ConvertToManaged_Public_Static_AnimationCurve_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num3);
    }

    [CallerCount(0)]
    public static unsafe System.IntPtr ConvertToNative(AnimationCurve animationCurve)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animationCurve)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_AnimationCurve_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public BindingsMarshaller(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
