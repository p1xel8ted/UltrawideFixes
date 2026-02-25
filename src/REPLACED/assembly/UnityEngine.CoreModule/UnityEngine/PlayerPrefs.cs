// Decompiled with JetBrains decompiler
// Type: UnityEngine.PlayerPrefs
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public class PlayerPrefs(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_TrySetInt_Private_Static_Boolean_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TrySetFloat_Private_Static_Boolean_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TrySetSetString_Private_Static_Boolean_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetInt_Public_Static_Void_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetFloat_Public_Static_Void_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetString_Public_Static_Void_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasKey_Public_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeleteAll_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TrySetInt_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TrySetFloat_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TrySetSetString_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInt_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFloat_Injected_Private_Static_Single_byref_ManagedSpanWrapper_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetString_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasKey_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeleteKey_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

  static PlayerPrefs()
  {
    Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (PlayerPrefs));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr);
    PlayerPrefs.NativeMethodInfoPtr_TrySetInt_Private_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667712);
    PlayerPrefs.NativeMethodInfoPtr_TrySetFloat_Private_Static_Boolean_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667713);
    PlayerPrefs.NativeMethodInfoPtr_TrySetSetString_Private_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667714);
    PlayerPrefs.NativeMethodInfoPtr_SetInt_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667715);
    PlayerPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667716);
    PlayerPrefs.NativeMethodInfoPtr_SetFloat_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667717);
    PlayerPrefs.NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667718);
    PlayerPrefs.NativeMethodInfoPtr_SetString_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667719);
    PlayerPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667720);
    PlayerPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667721);
    PlayerPrefs.NativeMethodInfoPtr_HasKey_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667722);
    PlayerPrefs.NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667723);
    PlayerPrefs.NativeMethodInfoPtr_DeleteAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667724);
    PlayerPrefs.NativeMethodInfoPtr_Save_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667725);
    PlayerPrefs.NativeMethodInfoPtr_TrySetInt_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667726);
    PlayerPrefs.NativeMethodInfoPtr_TrySetFloat_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667727);
    PlayerPrefs.NativeMethodInfoPtr_TrySetSetString_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667728);
    PlayerPrefs.NativeMethodInfoPtr_GetInt_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667729);
    PlayerPrefs.NativeMethodInfoPtr_GetFloat_Injected_Private_Static_Single_byref_ManagedSpanWrapper_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667730);
    PlayerPrefs.NativeMethodInfoPtr_GetString_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667731);
    PlayerPrefs.NativeMethodInfoPtr_HasKey_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667732);
    PlayerPrefs.NativeMethodInfoPtr_DeleteKey_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100667733);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441585, RefRangeEnd = 441586, XrefRangeStart = 441571, XrefRangeEnd = 441585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TrySetInt(string key, int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_TrySetInt_Private_Static_Boolean_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441600, RefRangeEnd = 441601, XrefRangeStart = 441586, XrefRangeEnd = 441600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TrySetFloat(string key, float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_TrySetFloat_Private_Static_Boolean_String_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441624, RefRangeEnd = 441625, XrefRangeStart = 441601, XrefRangeEnd = 441624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TrySetSetString(string key, string value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(value);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_TrySetSetString_Private_Static_Boolean_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441626, RefRangeEnd = 441627, XrefRangeStart = 441625, XrefRangeEnd = 441626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetInt(string key, int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_SetInt_Public_Static_Void_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441641, RefRangeEnd = 441642, XrefRangeStart = 441627, XrefRangeEnd = 441641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetInt(string key, int defaultValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValue;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441643, RefRangeEnd = 441644, XrefRangeStart = 441642, XrefRangeEnd = 441643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetFloat(string key, float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_SetFloat_Public_Static_Void_String_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441658, RefRangeEnd = 441659, XrefRangeStart = 441644, XrefRangeEnd = 441658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetFloat(string key, float defaultValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValue;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 441660, RefRangeEnd = 441673, XrefRangeStart = 441659, XrefRangeEnd = 441660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetString(string key, string value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(value);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_SetString_Public_Static_Void_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 441698, RefRangeEnd = 441700, XrefRangeStart = 441673, XrefRangeEnd = 441698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetString(string key, string defaultValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 441703, RefRangeEnd = 441717, XrefRangeStart = 441700, XrefRangeEnd = 441703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetString(string key)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(18)]
  [CachedScanResults(RefRangeStart = 441731, RefRangeEnd = 441749, XrefRangeStart = 441717, XrefRangeEnd = 441731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HasKey(string key)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_HasKey_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441763, RefRangeEnd = 441764, XrefRangeStart = 441749, XrefRangeEnd = 441763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DeleteKey(string key)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441766, RefRangeEnd = 441767, XrefRangeStart = 441764, XrefRangeEnd = 441766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DeleteAll()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_DeleteAll_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 441769, RefRangeEnd = 441783, XrefRangeStart = 441767, XrefRangeEnd = 441769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Save()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_Save_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441783, XrefRangeEnd = 441785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TrySetInt_Injected(ref ManagedSpanWrapper key, int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref key;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_TrySetInt_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441785, XrefRangeEnd = 441787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TrySetFloat_Injected(ref ManagedSpanWrapper key, float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref key;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_TrySetFloat_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441787, XrefRangeEnd = 441789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TrySetSetString_Injected(
    ref ManagedSpanWrapper key,
    ref ManagedSpanWrapper value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref key;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_TrySetSetString_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441789, XrefRangeEnd = 441791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetInt_Injected(ref ManagedSpanWrapper key, int defaultValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref key;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValue;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetInt_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441791, XrefRangeEnd = 441793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetFloat_Injected(ref ManagedSpanWrapper key, float defaultValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref key;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValue;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetFloat_Injected_Private_Static_Single_byref_ManagedSpanWrapper_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441793, XrefRangeEnd = 441795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetString_Injected(
    ref ManagedSpanWrapper key,
    ref ManagedSpanWrapper defaultValue,
    out ManagedSpanWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref key;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref defaultValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetString_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441795, XrefRangeEnd = 441797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HasKey_Injected(ref ManagedSpanWrapper key)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref key
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_HasKey_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441797, XrefRangeEnd = 441799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DeleteKey_Injected(ref ManagedSpanWrapper key)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref key
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_DeleteKey_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static int GetInt(string key) => PlayerPrefs.GetInt(key, 0);

  public static float GetFloat(string key) => PlayerPrefs.GetFloat(key, 0.0f);
}
