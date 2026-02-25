// Decompiled with JetBrains decompiler
// Type: UnityEngine.StackTraceUtility
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Diagnostics;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public static class StackTraceUtility : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_projectFolder;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetProjectFolder_Internal_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExtractStackTrace_Public_Static_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExtractStringFromExceptionInternal_Internal_Static_Void_Object_byref_String_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExtractFormattedStackTrace_Internal_Static_String_StackTrace_0;

  static StackTraceUtility()
  {
    Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (StackTraceUtility));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr);
    StackTraceUtility.NativeFieldInfoPtr_projectFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, nameof (projectFolder));
    StackTraceUtility.NativeMethodInfoPtr_SetProjectFolder_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100668259);
    StackTraceUtility.NativeMethodInfoPtr_ExtractStackTrace_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100668260);
    StackTraceUtility.NativeMethodInfoPtr_ExtractStringFromExceptionInternal_Internal_Static_Void_Object_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100668261);
    StackTraceUtility.NativeMethodInfoPtr_ExtractFormattedStackTrace_Internal_Static_String_StackTrace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100668262);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453171, XrefRangeEnd = 453186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetProjectFolder(string folder)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(folder)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_SetProjectFolder_Internal_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453186, XrefRangeEnd = 453203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ExtractStackTrace()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_ExtractStackTrace_Public_Static_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453203, XrefRangeEnd = 453240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ExtractStringFromExceptionInternal(
    Il2CppSystem.Object exceptiono,
    out string message,
    out string stackTrace)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) exceptiono);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero1 = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero1;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero2 = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero2;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
    System.IntPtr num3;
    IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_ExtractStringFromExceptionInternal_Internal_Static_Void_Object_byref_String_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    message = IL2CPP.Il2CppStringToManaged(zero1);
    stackTrace = IL2CPP.Il2CppStringToManaged(zero2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 453339, RefRangeEnd = 453341, XrefRangeStart = 453240, XrefRangeEnd = 453339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ExtractFormattedStackTrace(StackTrace stackFrames)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stackFrames)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_ExtractFormattedStackTrace_Internal_Static_String_StackTrace_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public StackTraceUtility(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string projectFolder
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(StackTraceUtility.NativeFieldInfoPtr_projectFolder, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StackTraceUtility.NativeFieldInfoPtr_projectFolder, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static string ExtractStringFromException(Il2CppSystem.Object exception)
  {
    string message;
    string stackTrace;
    StackTraceUtility.ExtractStringFromExceptionInternal(exception, out message, out stackTrace);
    return Il2CppSystem.String.Concat(message, "\n", stackTrace);
  }
}
