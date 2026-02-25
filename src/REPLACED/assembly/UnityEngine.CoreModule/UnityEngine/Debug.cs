// Decompiled with JetBrains decompiler
// Type: UnityEngine.Debug
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

public class Debug(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_DefaultLogger;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Logger;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_unityLogger_Public_Static_get_ILogger_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Break_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Public_Static_Int32_ptr_Byte_Int32_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogFormat_Public_Static_Void_LogType_LogOption_Object_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_developerConsoleEnabled_Public_Static_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogAssertion_Public_Static_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogAssertionFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isDebugBuild_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CallOverridenDebugHandler_Internal_Static_Boolean_Exception_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsLoggingEnabled_Internal_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Color_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Injected_Private_Static_Int32_ptr_Byte_Int32_byref_ManagedSpanWrapper_0;
  private static readonly Debug.DebugBreakDelegate DebugBreakDelegateField;
  private static readonly Debug.ClearDeveloperConsoleDelegate ClearDeveloperConsoleDelegateField;
  private static readonly Debug.get_developerConsoleEnabledDelegate get_developerConsoleEnabledDelegateField;
  private static readonly Debug.get_developerConsoleVisibleDelegate get_developerConsoleVisibleDelegateField;
  private static readonly Debug.set_developerConsoleVisibleDelegate set_developerConsoleVisibleDelegateField;
  private static readonly Debug.get_diagnosticSwitchesDelegate get_diagnosticSwitchesDelegateField;
  private static readonly Debug.IsValidationLevelEnabledDelegate IsValidationLevelEnabledDelegateField;
  private static readonly Debug.CheckIntegrity_InjectedDelegate CheckIntegrity_InjectedDelegateField;

  static Debug()
  {
    Il2CppClassPointerStore<Debug>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Debug));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Debug>.NativeClassPtr);
    Debug.NativeFieldInfoPtr_s_DefaultLogger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug>.NativeClassPtr, nameof (s_DefaultLogger));
    Debug.NativeFieldInfoPtr_s_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug>.NativeClassPtr, nameof (s_Logger));
    Debug.NativeMethodInfoPtr_get_unityLogger_Public_Static_get_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664374);
    Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664375);
    Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664376);
    Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664377);
    Debug.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664378);
    Debug.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664379);
    Debug.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664380);
    Debug.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664381);
    Debug.NativeMethodInfoPtr_Break_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664382);
    Debug.NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Public_Static_Int32_ptr_Byte_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664383);
    Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664384 /*0x06000440*/);
    Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664385);
    Debug.NativeMethodInfoPtr_LogFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664386);
    Debug.NativeMethodInfoPtr_LogFormat_Public_Static_Void_LogType_LogOption_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664387);
    Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664388);
    Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664389);
    Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664390);
    Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664391);
    Debug.NativeMethodInfoPtr_set_developerConsoleEnabled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664392);
    Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664393);
    Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664394);
    Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664395);
    Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664396);
    Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664397);
    Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664398);
    Debug.NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664399);
    Debug.NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664400 /*0x06000450*/);
    Debug.NativeMethodInfoPtr_LogAssertion_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664401);
    Debug.NativeMethodInfoPtr_LogAssertionFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664402);
    Debug.NativeMethodInfoPtr_get_isDebugBuild_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664403);
    Debug.NativeMethodInfoPtr_CallOverridenDebugHandler_Internal_Static_Boolean_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664404);
    Debug.NativeMethodInfoPtr_IsLoggingEnabled_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664405);
    Debug.NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664407);
    Debug.NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Injected_Private_Static_Int32_ptr_Byte_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664408);
    Debug.DebugBreakDelegateField = IL2CPP.ResolveICall<Debug.DebugBreakDelegate>("UnityEngine.Debug::DebugBreak");
    Debug.ClearDeveloperConsoleDelegateField = IL2CPP.ResolveICall<Debug.ClearDeveloperConsoleDelegate>("UnityEngine.Debug::ClearDeveloperConsole");
    Debug.get_developerConsoleEnabledDelegateField = IL2CPP.ResolveICall<Debug.get_developerConsoleEnabledDelegate>("UnityEngine.Debug::get_developerConsoleEnabled");
    Debug.get_developerConsoleVisibleDelegateField = IL2CPP.ResolveICall<Debug.get_developerConsoleVisibleDelegate>("UnityEngine.Debug::get_developerConsoleVisible");
    Debug.set_developerConsoleVisibleDelegateField = IL2CPP.ResolveICall<Debug.set_developerConsoleVisibleDelegate>("UnityEngine.Debug::set_developerConsoleVisible");
    Debug.get_diagnosticSwitchesDelegateField = IL2CPP.ResolveICall<Debug.get_diagnosticSwitchesDelegate>("UnityEngine.Debug::get_diagnosticSwitches");
    Debug.IsValidationLevelEnabledDelegateField = IL2CPP.ResolveICall<Debug.IsValidationLevelEnabledDelegate>("UnityEngine.Debug::IsValidationLevelEnabled");
    Debug.CheckIntegrity_InjectedDelegateField = IL2CPP.ResolveICall<Debug.CheckIntegrity_InjectedDelegate>("UnityEngine.Debug::CheckIntegrity_Injected");
  }

  public static unsafe ILogger unityLogger
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 419725, XrefRangeEnd = 419729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_get_unityLogger_Public_Static_get_ILogger_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ILogger) null : Il2CppObjectPool.Get<ILogger>(num3);
    }
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 419737, RefRangeEnd = 419760, XrefRangeStart = 419729, XrefRangeEnd = 419737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 419768, RefRangeEnd = 419776, XrefRangeStart = 419760, XrefRangeEnd = 419768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawLine(Vector3 start, Vector3 end, Color color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 419781, RefRangeEnd = 419782, XrefRangeStart = 419776, XrefRangeEnd = 419781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawLine(
    Vector3 start,
    Vector3 end,
    Color color,
    float duration,
    bool depthTest)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 419786, RefRangeEnd = 419787, XrefRangeStart = 419782, XrefRangeEnd = 419786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dir;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 419791, RefRangeEnd = 419797, XrefRangeStart = 419787, XrefRangeEnd = 419791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawRay(Vector3 start, Vector3 dir, Color color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dir;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 419801, RefRangeEnd = 419802, XrefRangeStart = 419797, XrefRangeEnd = 419801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawRay(Vector3 start, Vector3 dir)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dir;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 419810, RefRangeEnd = 419813, XrefRangeStart = 419802, XrefRangeEnd = 419810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawRay(
    Vector3 start,
    Vector3 dir,
    Color color,
    float duration,
    bool depthTest)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dir;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 419815, RefRangeEnd = 419816, XrefRangeStart = 419813, XrefRangeEnd = 419815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Break()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Break_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 419833, RefRangeEnd = 419834, XrefRangeStart = 419816, XrefRangeEnd = 419833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int ExtractStackTraceNoAlloc(
    byte* buffer,
    int bufferMax,
    string projectFolder)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) buffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bufferMax;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(projectFolder);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Public_Static_Int32_ptr_Byte_Int32_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(146)]
  [CachedScanResults(RefRangeStart = 419844, RefRangeEnd = 419990, XrefRangeStart = 419834, XrefRangeEnd = 419844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Log(Il2CppSystem.Object message)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) message)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 420000, RefRangeEnd = 420003, XrefRangeStart = 419990, XrefRangeEnd = 420000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Log(Il2CppSystem.Object message, Object context)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) message);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 420013, RefRangeEnd = 420020, XrefRangeStart = 420003, XrefRangeEnd = 420013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogFormat(string format, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    if (args == null)
      args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 420043, RefRangeEnd = 420045, XrefRangeStart = 420020, XrefRangeEnd = 420043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogFormat(
    LogType logType,
    LogOption logOptions,
    Object context,
    string format,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    if (args == null)
      args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &logType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &logOptions;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogFormat_Public_Static_Void_LogType_LogOption_Object_String_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(248)]
  [CachedScanResults(RefRangeStart = 420055, RefRangeEnd = 420303, XrefRangeStart = 420045, XrefRangeEnd = 420055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogError(Il2CppSystem.Object message)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) message)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(22)]
  [CachedScanResults(RefRangeStart = 420313, RefRangeEnd = 420335, XrefRangeStart = 420303, XrefRangeEnd = 420313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogError(Il2CppSystem.Object message, Object context)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) message);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(18)]
  [CachedScanResults(RefRangeStart = 420345, RefRangeEnd = 420363, XrefRangeStart = 420335, XrefRangeEnd = 420345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogErrorFormat(string format, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    if (args == null)
      args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 420373, RefRangeEnd = 420377, XrefRangeStart = 420363, XrefRangeEnd = 420373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogErrorFormat(
    Object context,
    string format,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    if (args == null)
      args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe bool developerConsoleEnabled
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 420379, RefRangeEnd = 420380, XrefRangeStart = 420377, XrefRangeEnd = 420379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_set_developerConsoleEnabled_Public_Static_set_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => Debug.get_developerConsoleEnabledDelegateField();
  }

  [CallerCount(38)]
  [CachedScanResults(RefRangeStart = 420390, RefRangeEnd = 420428, XrefRangeStart = 420380, XrefRangeEnd = 420390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogException(Il2CppSystem.Exception exception)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) exception)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 420438, RefRangeEnd = 420444, XrefRangeStart = 420428, XrefRangeEnd = 420438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogException(Il2CppSystem.Exception exception, Object context)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) exception);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(172)]
  [CachedScanResults(RefRangeStart = 420454, RefRangeEnd = 420626, XrefRangeStart = 420444, XrefRangeEnd = 420454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogWarning(Il2CppSystem.Object message)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) message)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(36)]
  [CachedScanResults(RefRangeStart = 420636, RefRangeEnd = 420672, XrefRangeStart = 420626, XrefRangeEnd = 420636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogWarning(Il2CppSystem.Object message, Object context)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) message);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 420682, RefRangeEnd = 420691, XrefRangeStart = 420672, XrefRangeEnd = 420682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogWarningFormat(string format, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    if (args == null)
      args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 420701, RefRangeEnd = 420704, XrefRangeStart = 420691, XrefRangeEnd = 420701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogWarningFormat(
    Object context,
    string format,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    if (args == null)
      args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(231)]
  [CachedScanResults(RefRangeStart = 420716, RefRangeEnd = 420947, XrefRangeStart = 420704, XrefRangeEnd = 420716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Assert(bool condition)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &condition
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(54)]
  [CachedScanResults(RefRangeStart = 420957, RefRangeEnd = 421011, XrefRangeStart = 420947, XrefRangeEnd = 420957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Assert(bool condition, string message)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &condition;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 421021, RefRangeEnd = 421028, XrefRangeStart = 421011, XrefRangeEnd = 421021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogAssertion(Il2CppSystem.Object message)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) message)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogAssertion_Public_Static_Void_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 421038, RefRangeEnd = 421040, XrefRangeStart = 421028, XrefRangeEnd = 421038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogAssertionFormat(string format, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    if (args == null)
      args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogAssertionFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe bool isDebugBuild
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 421042, RefRangeEnd = 421048, XrefRangeStart = 421040, XrefRangeEnd = 421042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_get_isDebugBuild_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421048, XrefRangeEnd = 421069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CallOverridenDebugHandler(Il2CppSystem.Exception exception, Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) exception);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_CallOverridenDebugHandler_Internal_Static_Boolean_Exception_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421069, XrefRangeEnd = 421093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsLoggingEnabled()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_IsLoggingEnabled_Internal_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421093, XrefRangeEnd = 421095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawLine_Injected(
    [In] ref Vector3 start,
    [In] ref Vector3 end,
    [In] ref Color color,
    float duration,
    bool depthTest)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) ref start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Color_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421095, XrefRangeEnd = 421097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int ExtractStackTraceNoAlloc_Injected(
    byte* buffer,
    int bufferMax,
    ref ManagedSpanWrapper projectFolder)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) buffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bufferMax;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref projectFolder;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Injected_Private_Static_Int32_ptr_Byte_Int32_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static void LogFormat(string format, params Il2CppSystem.Object[] args)
  {
    Debug.LogFormat(format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  public static void LogFormat(
    LogType logType,
    LogOption logOptions,
    Object context,
    string format,
    params Il2CppSystem.Object[] args)
  {
    Debug.LogFormat(logType, logOptions, context, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  public static void LogErrorFormat(string format, params Il2CppSystem.Object[] args)
  {
    Debug.LogErrorFormat(format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  public static void LogErrorFormat(Object context, string format, params Il2CppSystem.Object[] args)
  {
    Debug.LogErrorFormat(context, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  public static void LogWarningFormat(string format, params Il2CppSystem.Object[] args)
  {
    Debug.LogWarningFormat(format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  public static void LogWarningFormat(Object context, string format, params Il2CppSystem.Object[] args)
  {
    Debug.LogWarningFormat(context, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  public static void LogAssertionFormat(string format, params Il2CppSystem.Object[] args)
  {
    Debug.LogAssertionFormat(format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  public static unsafe ILogger s_DefaultLogger
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Debug.NativeFieldInfoPtr_s_DefaultLogger, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ILogger) null : Il2CppObjectPool.Get<ILogger>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Debug.NativeFieldInfoPtr_s_DefaultLogger, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe ILogger s_Logger
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Debug.NativeFieldInfoPtr_s_Logger, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ILogger) null : Il2CppObjectPool.Get<ILogger>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Debug.NativeFieldInfoPtr_s_Logger, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static void DrawLine(Vector3 start, Vector3 end)
  {
    bool depthTest = true;
    float duration = 0.0f;
    Color white = Color.white;
    Debug.DrawLine(start, end, white, duration, depthTest);
  }

  public static void DebugBreak() => Debug.DebugBreakDelegateField();

  public static void LogFormat(Object context, string format, Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    ((ILogHandler) Debug.unityLogger).LogFormat(LogType.Log, context, format, args);
  }

  public static void LogFormat(Object context, string format, params Il2CppSystem.Object[] args)
  {
    Debug.LogFormat(context, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  public static void ClearDeveloperConsole() => Debug.ClearDeveloperConsoleDelegateField();

  public static bool developerConsoleVisible
  {
    get => Debug.get_developerConsoleVisibleDelegateField();
    set => Debug.set_developerConsoleVisibleDelegateField(value);
  }

  public static void Assert(bool condition, Object context)
  {
    if (condition)
      return;
    Debug.unityLogger.Log(LogType.Assert, (Il2CppSystem.Object) "Assertion failed", context);
  }

  public static void Assert(bool condition, Il2CppSystem.Object message)
  {
    if (condition)
      return;
    Debug.unityLogger.Log(LogType.Assert, message);
  }

  public static void Assert(bool condition, Il2CppSystem.Object message, Object context)
  {
    if (condition)
      return;
    Debug.unityLogger.Log(LogType.Assert, message, context);
  }

  public static void Assert(bool condition, string message, Object context)
  {
    if (condition)
      return;
    Debug.unityLogger.Log(LogType.Assert, (Il2CppSystem.Object) message, context);
  }

  public static void AssertFormat(bool condition, string format, Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    if (condition)
      return;
    Debug.unityLogger.LogFormat(LogType.Assert, format, args);
  }

  public static void AssertFormat(bool condition, string format, params Il2CppSystem.Object[] args)
  {
    Debug.AssertFormat(condition, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  public static void AssertFormat(
    bool condition,
    Object context,
    string format,
    Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    if (condition)
      return;
    ((ILogHandler) Debug.unityLogger).LogFormat(LogType.Assert, context, format, args);
  }

  public static void AssertFormat(
    bool condition,
    Object context,
    string format,
    params Il2CppSystem.Object[] args)
  {
    Debug.AssertFormat(condition, context, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  public static void LogAssertion(Il2CppSystem.Object message, Object context)
  {
    Debug.unityLogger.Log(LogType.Assert, message, context);
  }

  public static void LogAssertionFormat(
    Object context,
    string format,
    Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    ((ILogHandler) Debug.unityLogger).LogFormat(LogType.Assert, context, format, args);
  }

  public static void LogAssertionFormat(Object context, string format, params Il2CppSystem.Object[] args)
  {
    Debug.LogAssertionFormat(context, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  public static Il2CppReferenceArray<DiagnosticSwitch> diagnosticSwitches
  {
    get
    {
      System.IntPtr num = Debug.get_diagnosticSwitchesDelegateField();
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<DiagnosticSwitch>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<DiagnosticSwitch>>(num);
    }
  }

  public static DiagnosticSwitch GetDiagnosticSwitch(string name)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static string CheckIntegrity(IntegrityCheckLevel level)
  {
    ManagedSpanWrapper ret;
    string stringAndDispose;
    try
    {
      Debug.CheckIntegrity_Injected(level, out ret);
    }
    finally
    {
      stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
    }
    return stringAndDispose;
  }

  public static bool IsValidationLevelEnabled(ValidationLevel level)
  {
    return Debug.IsValidationLevelEnabledDelegateField(level);
  }

  public static void Assert(bool condition, string format, Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    if (condition)
      return;
    Debug.unityLogger.LogFormat(LogType.Assert, format, args);
  }

  public static void Assert(bool condition, string format, params Il2CppSystem.Object[] args)
  {
    Debug.Assert(condition, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  public static ILogger logger => Debug.s_Logger;

  public static void CheckIntegrity_Injected(IntegrityCheckLevel level, out ManagedSpanWrapper ret)
  {
    Debug.CheckIntegrity_InjectedDelegateField(level, (System.IntPtr) ref ret);
  }

  private delegate void DebugBreakDelegate();

  private delegate void ClearDeveloperConsoleDelegate();

  private delegate bool get_developerConsoleEnabledDelegate();

  private delegate bool get_developerConsoleVisibleDelegate();

  private delegate void set_developerConsoleVisibleDelegate(bool value);

  private delegate System.IntPtr get_diagnosticSwitchesDelegate();

  private delegate bool IsValidationLevelEnabledDelegate(ValidationLevel level);

  private delegate void CheckIntegrity_InjectedDelegate(IntegrityCheckLevel level, [Out] System.IntPtr ret);
}
