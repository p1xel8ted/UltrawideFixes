// Decompiled with JetBrains decompiler
// Type: UnityEngine.UnityLogWriter
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;
using System;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public class UnityLogWriter(IntPtr pointer) : TextWriter(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_WriteStringToUnityLog_Public_Static_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_WriteStringToUnityLogImpl_Private_Static_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0;
  private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0;
  private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_WriteStringToUnityLogImpl_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

  static UnityLogWriter()
  {
    Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (UnityLogWriter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr);
    UnityLogWriter.NativeMethodInfoPtr_WriteStringToUnityLog_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100667232 /*0x06000F60*/);
    UnityLogWriter.NativeMethodInfoPtr_WriteStringToUnityLogImpl_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100667233);
    UnityLogWriter.NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100667234);
    UnityLogWriter.NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100667235);
    UnityLogWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100667236);
    UnityLogWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100667237);
    UnityLogWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100667238);
    UnityLogWriter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100667239);
    UnityLogWriter.NativeMethodInfoPtr_WriteStringToUnityLogImpl_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100667240);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437991, XrefRangeEnd = 437992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void WriteStringToUnityLog(string s)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(s)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityLogWriter.NativeMethodInfoPtr_WriteStringToUnityLog_Public_Static_Void_String_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 438006, RefRangeEnd = 438010, XrefRangeStart = 437992, XrefRangeEnd = 438006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void WriteStringToUnityLogImpl(string s)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(s)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityLogWriter.NativeMethodInfoPtr_WriteStringToUnityLogImpl_Private_Static_Void_String_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 438026, RefRangeEnd = 438027, XrefRangeStart = 438010, XrefRangeEnd = 438026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Init()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityLogWriter.NativeMethodInfoPtr_Init_Public_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public override unsafe Encoding Encoding
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438027, XrefRangeEnd = 438028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityLogWriter.NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Encoding) null : Il2CppObjectPool.Get<Encoding>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438028, XrefRangeEnd = 438032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Write(char value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityLogWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438032, XrefRangeEnd = 438033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Write(string s)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(s)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityLogWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438033, XrefRangeEnd = 438035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Write(Il2CppStructArray<char> buffer, int index, int count)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffer);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &index;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &count;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityLogWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438035, XrefRangeEnd = 438039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityLogWriter()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityLogWriter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438039, XrefRangeEnd = 438041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void WriteStringToUnityLogImpl_Injected(ref ManagedSpanWrapper s)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) ref s
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityLogWriter.NativeMethodInfoPtr_WriteStringToUnityLogImpl_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
