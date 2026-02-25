// Decompiled with JetBrains decompiler
// Type: UnityEngine.TextAsset
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public class TextAsset(System.IntPtr pointer) : Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_get_bytes_Public_get_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPreviewBytes_Private_Il2CppStructArray_1_Byte_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateInstance_Private_Static_Void_TextAsset_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateInstanceFromBytes_Private_Static_Void_TextAsset_ReadOnlySpan_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDataPtr_Private_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDataSize_Private_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_dataSize_Public_get_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CreateOptions_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CreateOptions_ReadOnlySpan_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPreview_Internal_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_bytes_Injected_Private_Static_Il2CppStructArray_1_Byte_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPreviewBytes_Injected_Private_Static_Il2CppStructArray_1_Byte_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateInstance_Injected_Private_Static_Void_TextAsset_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateInstanceFromBytes_Injected_Private_Static_Void_TextAsset_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDataPtr_Injected_Private_Static_IntPtr_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDataSize_Injected_Private_Static_Int64_IntPtr_0;

  static TextAsset()
  {
    Il2CppClassPointerStore<TextAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (TextAsset));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextAsset>.NativeClassPtr);
    TextAsset.NativeMethodInfoPtr_get_bytes_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668273);
    TextAsset.NativeMethodInfoPtr_GetPreviewBytes_Private_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668274);
    TextAsset.NativeMethodInfoPtr_Internal_CreateInstance_Private_Static_Void_TextAsset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668275);
    TextAsset.NativeMethodInfoPtr_Internal_CreateInstanceFromBytes_Private_Static_Void_TextAsset_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668276);
    TextAsset.NativeMethodInfoPtr_GetDataPtr_Private_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668277);
    TextAsset.NativeMethodInfoPtr_GetDataSize_Private_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668278);
    TextAsset.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668279);
    TextAsset.NativeMethodInfoPtr_get_dataSize_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668280);
    TextAsset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668281);
    TextAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668282);
    TextAsset.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668283);
    TextAsset.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668284);
    TextAsset.NativeMethodInfoPtr__ctor_Internal_Void_CreateOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668285);
    TextAsset.NativeMethodInfoPtr__ctor_Internal_Void_CreateOptions_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668286);
    TextAsset.NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668287);
    TextAsset.NativeMethodInfoPtr_GetPreview_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668288);
    TextAsset.NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668289);
    TextAsset.NativeMethodInfoPtr_get_bytes_Injected_Private_Static_Il2CppStructArray_1_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668290);
    TextAsset.NativeMethodInfoPtr_GetPreviewBytes_Injected_Private_Static_Il2CppStructArray_1_Byte_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668291);
    TextAsset.NativeMethodInfoPtr_Internal_CreateInstance_Injected_Private_Static_Void_TextAsset_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668292);
    TextAsset.NativeMethodInfoPtr_Internal_CreateInstanceFromBytes_Injected_Private_Static_Void_TextAsset_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668293);
    TextAsset.NativeMethodInfoPtr_GetDataPtr_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668294);
    TextAsset.NativeMethodInfoPtr_GetDataSize_Injected_Private_Static_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100668295);
  }

  public unsafe Il2CppStructArray<byte> bytes
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 453388, RefRangeEnd = 453393, XrefRangeStart = 453383, XrefRangeEnd = 453388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_get_bytes_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : Il2CppObjectPool.Get<Il2CppStructArray<byte>>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453393, XrefRangeEnd = 453398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppStructArray<byte> GetPreviewBytes(int maxByteCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &maxByteCount
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_GetPreviewBytes_Private_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : Il2CppObjectPool.Get<Il2CppStructArray<byte>>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 453412, RefRangeEnd = 453415, XrefRangeStart = 453398, XrefRangeEnd = 453412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_CreateInstance(TextAsset self, string text)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) self);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_Internal_CreateInstance_Private_Static_Void_TextAsset_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453415, XrefRangeEnd = 453422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_CreateInstanceFromBytes(
    TextAsset self,
    Il2CppSystem.ReadOnlySpan<byte> bytes)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) self);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) bytes));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_Internal_CreateInstanceFromBytes_Private_Static_Void_TextAsset_ReadOnlySpan_1_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 453427, RefRangeEnd = 453428, XrefRangeStart = 453422, XrefRangeEnd = 453427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe System.IntPtr GetDataPtr()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_GetDataPtr_Private_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 453433, RefRangeEnd = 453434, XrefRangeStart = 453428, XrefRangeEnd = 453433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe long GetDataSize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_GetDataSize_Private_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(long*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe string text
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 453439, RefRangeEnd = 453444, XrefRangeStart = 453434, XrefRangeEnd = 453439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe long dataSize
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 453433, RefRangeEnd = 453434, XrefRangeStart = 453433, XrefRangeEnd = 453434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_get_dataSize_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(long*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 453439, RefRangeEnd = 453444, XrefRangeStart = 453439, XrefRangeEnd = 453444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TextAsset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453444, XrefRangeEnd = 453449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TextAsset()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextAsset>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453449, XrefRangeEnd = 453454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TextAsset(string text)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextAsset>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453454, XrefRangeEnd = 453465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TextAsset(Il2CppSystem.ReadOnlySpan<byte> bytes)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextAsset>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) bytes))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453465, XrefRangeEnd = 453470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TextAsset(TextAsset.CreateOptions options, string text)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextAsset>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &options;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr__ctor_Internal_Void_CreateOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453470, XrefRangeEnd = 453481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TextAsset(TextAsset.CreateOptions options, Il2CppSystem.ReadOnlySpan<byte> bytes)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextAsset>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &options;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) bytes));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr__ctor_Internal_Void_CreateOptions_ReadOnlySpan_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453481, XrefRangeEnd = 453486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeArray<T> GetData<T>() where T : new()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TextAsset.MethodInfoStoreGeneric_GetData_Public_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new NativeArray<T>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453486, XrefRangeEnd = 453492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetPreview(int maxChars)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &maxChars
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_GetPreview_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 453509, RefRangeEnd = 453510, XrefRangeStart = 453492, XrefRangeEnd = 453509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string DecodeString(Il2CppStructArray<byte> bytes)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bytes)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453510, XrefRangeEnd = 453512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStructArray<byte> get_bytes_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_get_bytes_Injected_Private_Static_Il2CppStructArray_1_Byte_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : Il2CppObjectPool.Get<Il2CppStructArray<byte>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453512, XrefRangeEnd = 453514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStructArray<byte> GetPreviewBytes_Injected(
    System.IntPtr _unity_self,
    int maxByteCount)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxByteCount;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_GetPreviewBytes_Injected_Private_Static_Il2CppStructArray_1_Byte_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : Il2CppObjectPool.Get<Il2CppStructArray<byte>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453514, XrefRangeEnd = 453516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_CreateInstance_Injected(
    TextAsset self,
    ref ManagedSpanWrapper text)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) self);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref text;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_Internal_CreateInstance_Injected_Private_Static_Void_TextAsset_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453516, XrefRangeEnd = 453518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_CreateInstanceFromBytes_Injected(
    TextAsset self,
    ref ManagedSpanWrapper bytes)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) self);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref bytes;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_Internal_CreateInstanceFromBytes_Injected_Private_Static_Void_TextAsset_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453518, XrefRangeEnd = 453520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr GetDataPtr_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_GetDataPtr_Injected_Private_Static_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453520, XrefRangeEnd = 453522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe long GetDataSize_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_GetDataSize_Injected_Private_Static_Int64_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(long*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public enum CreateOptions
  {
    None,
    CreateNativeObject,
  }

  public static class EncodingUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_encodingLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr_targetEncoding;

    static EncodingUtility()
    {
      Il2CppClassPointerStore<TextAsset.EncodingUtility>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, nameof (EncodingUtility));
      TextAsset.EncodingUtility.NativeFieldInfoPtr_encodingLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAsset.EncodingUtility>.NativeClassPtr, nameof (encodingLookup));
      TextAsset.EncodingUtility.NativeFieldInfoPtr_targetEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAsset.EncodingUtility>.NativeClassPtr, nameof (targetEncoding));
    }

    public EncodingUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Il2CppReferenceArray<KeyValuePair<Il2CppStructArray<byte>, Encoding>> encodingLookup
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_encodingLookup, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppReferenceArray<KeyValuePair<Il2CppStructArray<byte>, Encoding>>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<Il2CppStructArray<byte>, Encoding>>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_encodingLookup, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Encoding targetEncoding
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_targetEncoding, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Encoding) null : Il2CppObjectPool.Get<Encoding>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_targetEncoding, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_GetData_Public_NativeArray_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TextAsset.NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_0, Il2CppClassPointerStore<TextAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
