// Decompiled with JetBrains decompiler
// Type: UnityEngine.Gradient
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

public class Gradient(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RequiresNativeCleanup;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Private_Static_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_colorKeys_Public_get_Il2CppStructArray_1_GradientColorKey_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_colorKeys_Public_set_Void_Il2CppStructArray_1_GradientColorKey_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_alphaKeys_Public_get_Il2CppStructArray_1_GradientAlphaKey_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_alphaKeys_Public_set_Void_Il2CppStructArray_1_GradientAlphaKey_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_mode_Public_get_GradientMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_mode_Public_set_Void_GradientMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_colorSpace_Public_get_ColorSpace_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_colorSpace_Public_set_Void_ColorSpace_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetKeys_Public_Void_Il2CppStructArray_1_GradientColorKey_Il2CppStructArray_1_GradientAlphaKey_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Gradient_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Injected_Private_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Equals_Injected_Private_Static_Boolean_IntPtr_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Injected_Private_Static_Void_IntPtr_Single_byref_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_colorKeys_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_colorKeys_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_alphaKeys_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_alphaKeys_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_mode_Injected_Private_Static_GradientMode_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_mode_Injected_Private_Static_Void_IntPtr_GradientMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_colorSpace_Injected_Private_Static_ColorSpace_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_colorSpace_Injected_Private_Static_Void_IntPtr_ColorSpace_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetKeys_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0;

  static Gradient()
  {
    Il2CppClassPointerStore<Gradient>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Gradient));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gradient>.NativeClassPtr);
    Gradient.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, nameof (m_Ptr));
    Gradient.NativeFieldInfoPtr_m_RequiresNativeCleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, nameof (m_RequiresNativeCleanup));
    Gradient.NativeMethodInfoPtr_Init_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667289);
    Gradient.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667290);
    Gradient.NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667291);
    Gradient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667292);
    Gradient.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667294);
    Gradient.NativeMethodInfoPtr_Evaluate_Public_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667295);
    Gradient.NativeMethodInfoPtr_get_colorKeys_Public_get_Il2CppStructArray_1_GradientColorKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667296 /*0x06000FA0*/);
    Gradient.NativeMethodInfoPtr_set_colorKeys_Public_set_Void_Il2CppStructArray_1_GradientColorKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667297);
    Gradient.NativeMethodInfoPtr_get_alphaKeys_Public_get_Il2CppStructArray_1_GradientAlphaKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667298);
    Gradient.NativeMethodInfoPtr_set_alphaKeys_Public_set_Void_Il2CppStructArray_1_GradientAlphaKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667299);
    Gradient.NativeMethodInfoPtr_get_mode_Public_get_GradientMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667300);
    Gradient.NativeMethodInfoPtr_set_mode_Public_set_Void_GradientMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667301);
    Gradient.NativeMethodInfoPtr_get_colorSpace_Public_get_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667302);
    Gradient.NativeMethodInfoPtr_set_colorSpace_Public_set_Void_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667303);
    Gradient.NativeMethodInfoPtr_SetKeys_Public_Void_Il2CppStructArray_1_GradientColorKey_Il2CppStructArray_1_GradientAlphaKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667304);
    Gradient.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667305);
    Gradient.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667306);
    Gradient.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667307);
    Gradient.NativeMethodInfoPtr_Cleanup_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667308);
    Gradient.NativeMethodInfoPtr_Internal_Equals_Injected_Private_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667309);
    Gradient.NativeMethodInfoPtr_Evaluate_Injected_Private_Static_Void_IntPtr_Single_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667310);
    Gradient.NativeMethodInfoPtr_get_colorKeys_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667311);
    Gradient.NativeMethodInfoPtr_set_colorKeys_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667312 /*0x06000FB0*/);
    Gradient.NativeMethodInfoPtr_get_alphaKeys_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667313);
    Gradient.NativeMethodInfoPtr_set_alphaKeys_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667314);
    Gradient.NativeMethodInfoPtr_get_mode_Injected_Private_Static_GradientMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667315);
    Gradient.NativeMethodInfoPtr_set_mode_Injected_Private_Static_Void_IntPtr_GradientMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667316);
    Gradient.NativeMethodInfoPtr_get_colorSpace_Injected_Private_Static_ColorSpace_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667317);
    Gradient.NativeMethodInfoPtr_set_colorSpace_Injected_Private_Static_Void_IntPtr_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667318);
    Gradient.NativeMethodInfoPtr_SetKeys_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100667319);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438329, XrefRangeEnd = 438331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr Init()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Init_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438331, XrefRangeEnd = 438335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Cleanup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438335, XrefRangeEnd = 438339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Internal_Equals(System.IntPtr other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 438342, RefRangeEnd = 438348, XrefRangeStart = 438339, XrefRangeEnd = 438342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Gradient()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Gradient>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438348, XrefRangeEnd = 438354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void Finalize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Gradient.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 438357, RefRangeEnd = 438362, XrefRangeStart = 438354, XrefRangeEnd = 438357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Color Evaluate(float time)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &time
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Evaluate_Public_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Il2CppStructArray<GradientColorKey> colorKeys
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 438369, RefRangeEnd = 438380, XrefRangeStart = 438362, XrefRangeEnd = 438369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_get_colorKeys_Public_get_Il2CppStructArray_1_GradientColorKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStructArray<GradientColorKey>) null : Il2CppObjectPool.Get<Il2CppStructArray<GradientColorKey>>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 438390, RefRangeEnd = 438392, XrefRangeStart = 438380, XrefRangeEnd = 438390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_set_colorKeys_Public_set_Void_Il2CppStructArray_1_GradientColorKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStructArray<GradientAlphaKey> alphaKeys
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 438399, RefRangeEnd = 438406, XrefRangeStart = 438392, XrefRangeEnd = 438399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_get_alphaKeys_Public_get_Il2CppStructArray_1_GradientAlphaKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStructArray<GradientAlphaKey>) null : Il2CppObjectPool.Get<Il2CppStructArray<GradientAlphaKey>>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 438416, RefRangeEnd = 438418, XrefRangeStart = 438406, XrefRangeEnd = 438416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_set_alphaKeys_Public_set_Void_Il2CppStructArray_1_GradientAlphaKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe GradientMode mode
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 438422, RefRangeEnd = 438428, XrefRangeStart = 438418, XrefRangeEnd = 438422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_get_mode_Public_get_GradientMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(GradientMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 438432, RefRangeEnd = 438438, XrefRangeStart = 438428, XrefRangeEnd = 438432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_set_mode_Public_set_Void_GradientMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ColorSpace colorSpace
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 438442, RefRangeEnd = 438445, XrefRangeStart = 438438, XrefRangeEnd = 438442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_get_colorSpace_Public_get_ColorSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ColorSpace*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 438449, RefRangeEnd = 438453, XrefRangeStart = 438445, XrefRangeEnd = 438449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_set_colorSpace_Public_set_Void_ColorSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 438470, RefRangeEnd = 438475, XrefRangeStart = 438453, XrefRangeEnd = 438470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetKeys(
    Il2CppStructArray<GradientColorKey> colorKeys,
    Il2CppStructArray<GradientAlphaKey> alphaKeys)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) colorKeys);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) alphaKeys);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_SetKeys_Public_Void_Il2CppStructArray_1_GradientColorKey_Il2CppStructArray_1_GradientAlphaKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438475, XrefRangeEnd = 438488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Equals(Il2CppSystem.Object o)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) o)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Gradient.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438488, XrefRangeEnd = 438494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Gradient other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Gradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438494, XrefRangeEnd = 438495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Gradient.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438495, XrefRangeEnd = 438497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Cleanup_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Cleanup_Injected_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438497, XrefRangeEnd = 438499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Internal_Equals_Injected(System.IntPtr _unity_self, System.IntPtr other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &other;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Internal_Equals_Injected_Private_Static_Boolean_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438499, XrefRangeEnd = 438501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Evaluate_Injected(System.IntPtr _unity_self, float time, out Color ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Evaluate_Injected_Private_Static_Void_IntPtr_Single_byref_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438501, XrefRangeEnd = 438503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_colorKeys_Injected(
    System.IntPtr _unity_self,
    out BlittableArrayWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_get_colorKeys_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438503, XrefRangeEnd = 438505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_colorKeys_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_set_colorKeys_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438505, XrefRangeEnd = 438507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_alphaKeys_Injected(
    System.IntPtr _unity_self,
    out BlittableArrayWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_get_alphaKeys_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438507, XrefRangeEnd = 438509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_alphaKeys_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_set_alphaKeys_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438509, XrefRangeEnd = 438511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GradientMode get_mode_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_get_mode_Injected_Private_Static_GradientMode_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GradientMode*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438511, XrefRangeEnd = 438513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_mode_Injected(System.IntPtr _unity_self, GradientMode value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_set_mode_Injected_Private_Static_Void_IntPtr_GradientMode_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438513, XrefRangeEnd = 438515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ColorSpace get_colorSpace_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_get_colorSpace_Injected_Private_Static_ColorSpace_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ColorSpace*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438515, XrefRangeEnd = 438517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_colorSpace_Injected(System.IntPtr _unity_self, ColorSpace value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_set_colorSpace_Injected_Private_Static_Void_IntPtr_ColorSpace_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438517, XrefRangeEnd = 438519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetKeys_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper colorKeys,
    ref ManagedSpanWrapper alphaKeys)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref colorKeys;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref alphaKeys;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_SetKeys_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr m_Ptr
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_m_Ptr));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_m_Ptr)) = value;
    }
  }

  public unsafe bool m_RequiresNativeCleanup
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_m_RequiresNativeCleanup));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_m_RequiresNativeCleanup)) = value;
    }
  }

  public static class BindingsMarshaller : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_Gradient_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToManaged_Public_Static_Gradient_IntPtr_0;

    static BindingsMarshaller()
    {
      Il2CppClassPointerStore<Gradient.BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Gradient>.NativeClassPtr, nameof (BindingsMarshaller));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gradient.BindingsMarshaller>.NativeClassPtr);
      Gradient.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient.BindingsMarshaller>.NativeClassPtr, 100667320);
      Gradient.BindingsMarshaller.NativeMethodInfoPtr_ConvertToManaged_Public_Static_Gradient_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient.BindingsMarshaller>.NativeClassPtr, 100667321);
    }

    [CallerCount(0)]
    public static unsafe System.IntPtr ConvertToNative(Gradient graident)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graident)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Gradient.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_Gradient_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 438325, RefRangeEnd = 438329, XrefRangeStart = 438321, XrefRangeEnd = 438325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Gradient ConvertToManaged(System.IntPtr ptr)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &ptr
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Gradient.BindingsMarshaller.NativeMethodInfoPtr_ConvertToManaged_Public_Static_Gradient_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Gradient) null : Il2CppObjectPool.Get<Gradient>(num3);
    }

    public BindingsMarshaller(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
