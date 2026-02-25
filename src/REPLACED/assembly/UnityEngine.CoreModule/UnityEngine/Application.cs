// Decompiled with JetBrains decompiler
// Type: UnityEngine.Application
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;
using Il2CppSystem.Threading;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Diagnostics;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

#nullable disable
namespace UnityEngine;

public class Application(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_lowMemory;
  private static readonly System.IntPtr NativeFieldInfoPtr_memoryUsageChanged;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_LogCallbackHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_LogCallbackHandlerThreaded;
  private static readonly System.IntPtr NativeFieldInfoPtr_focusChanged;
  private static readonly System.IntPtr NativeFieldInfoPtr_deepLinkActivated;
  private static readonly System.IntPtr NativeFieldInfoPtr_wantsToQuit;
  private static readonly System.IntPtr NativeFieldInfoPtr_quitting;
  private static readonly System.IntPtr NativeFieldInfoPtr_unloading;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_currentCancellationTokenSource;
  private static readonly System.IntPtr NativeMethodInfoPtr_Quit_Public_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Quit_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isPlaying_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isFocused_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_runInBackground_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isBatchMode_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_unityVersion_Public_Static_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_unityVersionVer_Internal_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_unityVersionMaj_Internal_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_version_Public_Static_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OpenURL_Public_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_targetFrameRate_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_targetFrameRate_Public_Static_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_backgroundLoadingPriority_Public_Static_set_Void_ThreadPriority_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_systemLanguage_Public_Static_get_SystemLanguage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CallLowMemory_Internal_Static_Void_ApplicationMemoryUsage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasLogCallback_Internal_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CallLogCallback_Private_Static_Void_String_String_LogType_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_focusChanged_Public_Static_add_Void_Action_1_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_focusChanged_Public_Static_rem_Void_Action_1_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ApplicationWantsToQuit_Private_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_exitCancellationToken_Public_Static_get_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_InitializeExitCancellationToken_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_RaiseExitCancellationToken_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ApplicationQuit_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ApplicationUnload_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnBeforeRender_Internal_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeFocusChanged_Internal_Static_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeDeepLinkActivated_Internal_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_dataPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_streamingAssetsPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_persistentDataPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_unityVersion_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_version_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OpenURL_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;
  private static readonly Application.CancelQuitDelegate CancelQuitDelegateField;
  private static readonly Application.UnloadDelegate UnloadDelegateField;
  private static readonly Application.get_isLoadingLevelDelegate get_isLoadingLevelDelegateField;
  private static readonly Application.SimulateMemoryUsageDelegate SimulateMemoryUsageDelegateField;
  private static readonly Application.GetBuildTagsDelegate GetBuildTagsDelegateField;
  private static readonly Application.SetBuildTagsDelegate SetBuildTagsDelegateField;
  private static readonly Application.set_runInBackgroundDelegate set_runInBackgroundDelegateField;
  private static readonly Application.HasProLicenseDelegate HasProLicenseDelegateField;
  private static readonly Application.get_isTestRunDelegate get_isTestRunDelegateField;
  private static readonly Application.get_isBuildingEditorResourcesDelegate get_isBuildingEditorResourcesDelegateField;
  private static readonly Application.get_isHumanControllingUsDelegate get_isHumanControllingUsDelegateField;
  private static readonly Application.get_unityVersionMinDelegate get_unityVersionMinDelegateField;
  private static readonly Application.get_installModeDelegate get_installModeDelegateField;
  private static readonly Application.get_sandboxTypeDelegate get_sandboxTypeDelegateField;
  private static readonly Application.SetLogCallbackDefinedDelegate SetLogCallbackDefinedDelegateField;
  private static readonly Application.get_stackTraceLogTypeDelegate get_stackTraceLogTypeDelegateField;
  private static readonly Application.set_stackTraceLogTypeDelegate set_stackTraceLogTypeDelegateField;
  private static readonly Application.GetStackTraceLogTypeDelegate GetStackTraceLogTypeDelegateField;
  private static readonly Application.SetStackTraceLogTypeDelegate SetStackTraceLogTypeDelegateField;
  private static readonly Application.get_backgroundLoadingPriorityDelegate get_backgroundLoadingPriorityDelegateField;
  private static readonly Application.get_genuineDelegate get_genuineDelegateField;
  private static readonly Application.get_genuineCheckAvailableDelegate get_genuineCheckAvailableDelegateField;
  private static readonly Application.HasUserAuthorizationDelegate HasUserAuthorizationDelegateField;
  private static readonly Application.get_submitAnalyticsDelegate get_submitAnalyticsDelegateField;
  private static readonly Application.get_internetReachabilityDelegate get_internetReachabilityDelegateField;
  private static readonly Application.CanStreamedLevelBeLoaded_InjectedDelegate CanStreamedLevelBeLoaded_InjectedDelegateField;
  private static readonly Application.IsPlaying_InjectedDelegate IsPlaying_InjectedDelegateField;
  private static readonly Application.get_buildGUID_InjectedDelegate get_buildGUID_InjectedDelegateField;
  private static readonly Application.HasARGV_InjectedDelegate HasARGV_InjectedDelegateField;
  private static readonly Application.GetValueForARGV_InjectedDelegate GetValueForARGV_InjectedDelegateField;
  private static readonly Application.get_temporaryCachePath_InjectedDelegate get_temporaryCachePath_InjectedDelegateField;
  private static readonly Application.get_absoluteURL_InjectedDelegate get_absoluteURL_InjectedDelegateField;
  private static readonly Application.Internal_ExternalCall_InjectedDelegate Internal_ExternalCall_InjectedDelegateField;
  private static readonly Application.get_installerName_InjectedDelegate get_installerName_InjectedDelegateField;
  private static readonly Application.get_identifier_InjectedDelegate get_identifier_InjectedDelegateField;
  private static readonly Application.get_productName_InjectedDelegate get_productName_InjectedDelegateField;
  private static readonly Application.get_companyName_InjectedDelegate get_companyName_InjectedDelegateField;
  private static readonly Application.get_cloudProjectId_InjectedDelegate get_cloudProjectId_InjectedDelegateField;
  private static readonly Application.get_consoleLogPath_InjectedDelegate get_consoleLogPath_InjectedDelegateField;
  private static readonly Application.RequestUserAuthorization_InjectedDelegate RequestUserAuthorization_InjectedDelegateField;

  static Application()
  {
    Il2CppClassPointerStore<Application>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Application));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Application>.NativeClassPtr);
    Application.NativeFieldInfoPtr_lowMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, nameof (lowMemory));
    Application.NativeFieldInfoPtr_memoryUsageChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, nameof (memoryUsageChanged));
    Application.NativeFieldInfoPtr_s_LogCallbackHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, nameof (s_LogCallbackHandler));
    Application.NativeFieldInfoPtr_s_LogCallbackHandlerThreaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, nameof (s_LogCallbackHandlerThreaded));
    Application.NativeFieldInfoPtr_focusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, nameof (focusChanged));
    Application.NativeFieldInfoPtr_deepLinkActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, nameof (deepLinkActivated));
    Application.NativeFieldInfoPtr_wantsToQuit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, nameof (wantsToQuit));
    Application.NativeFieldInfoPtr_quitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, nameof (quitting));
    Application.NativeFieldInfoPtr_unloading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, nameof (unloading));
    Application.NativeFieldInfoPtr_s_currentCancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, nameof (s_currentCancellationTokenSource));
    Application.NativeMethodInfoPtr_Quit_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663854);
    Application.NativeMethodInfoPtr_Quit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663855);
    Application.NativeMethodInfoPtr_get_isPlaying_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663856 /*0x06000230*/);
    Application.NativeMethodInfoPtr_get_isFocused_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663857);
    Application.NativeMethodInfoPtr_get_runInBackground_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663858);
    Application.NativeMethodInfoPtr_get_isBatchMode_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663859);
    Application.NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663860);
    Application.NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663861);
    Application.NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663862);
    Application.NativeMethodInfoPtr_get_unityVersion_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663863);
    Application.NativeMethodInfoPtr_get_unityVersionVer_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663864);
    Application.NativeMethodInfoPtr_get_unityVersionMaj_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663865);
    Application.NativeMethodInfoPtr_get_version_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663866);
    Application.NativeMethodInfoPtr_OpenURL_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663867);
    Application.NativeMethodInfoPtr_get_targetFrameRate_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663868);
    Application.NativeMethodInfoPtr_set_targetFrameRate_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663869);
    Application.NativeMethodInfoPtr_set_backgroundLoadingPriority_Public_Static_set_Void_ThreadPriority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663870);
    Application.NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663871);
    Application.NativeMethodInfoPtr_get_systemLanguage_Public_Static_get_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663872 /*0x06000240*/);
    Application.NativeMethodInfoPtr_CallLowMemory_Internal_Static_Void_ApplicationMemoryUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663873);
    Application.NativeMethodInfoPtr_HasLogCallback_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663874);
    Application.NativeMethodInfoPtr_CallLogCallback_Private_Static_Void_String_String_LogType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663875);
    Application.NativeMethodInfoPtr_add_focusChanged_Public_Static_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663876);
    Application.NativeMethodInfoPtr_remove_focusChanged_Public_Static_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663877);
    Application.NativeMethodInfoPtr_Internal_ApplicationWantsToQuit_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663878);
    Application.NativeMethodInfoPtr_get_exitCancellationToken_Public_Static_get_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663879);
    Application.NativeMethodInfoPtr_Internal_InitializeExitCancellationToken_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663880);
    Application.NativeMethodInfoPtr_Internal_RaiseExitCancellationToken_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663881);
    Application.NativeMethodInfoPtr_Internal_ApplicationQuit_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663882);
    Application.NativeMethodInfoPtr_Internal_ApplicationUnload_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663883);
    Application.NativeMethodInfoPtr_InvokeOnBeforeRender_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663884);
    Application.NativeMethodInfoPtr_InvokeFocusChanged_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663885);
    Application.NativeMethodInfoPtr_InvokeDeepLinkActivated_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663886);
    Application.NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663887);
    Application.NativeMethodInfoPtr_get_dataPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663889);
    Application.NativeMethodInfoPtr_get_streamingAssetsPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663890);
    Application.NativeMethodInfoPtr_get_persistentDataPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663891);
    Application.NativeMethodInfoPtr_get_unityVersion_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663892);
    Application.NativeMethodInfoPtr_get_version_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663893);
    Application.NativeMethodInfoPtr_OpenURL_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663894);
    Application.CancelQuitDelegateField = IL2CPP.ResolveICall<Application.CancelQuitDelegate>("UnityEngine.Application::CancelQuit");
    Application.UnloadDelegateField = IL2CPP.ResolveICall<Application.UnloadDelegate>("UnityEngine.Application::Unload");
    Application.get_isLoadingLevelDelegateField = IL2CPP.ResolveICall<Application.get_isLoadingLevelDelegate>("UnityEngine.Application::get_isLoadingLevel");
    Application.SimulateMemoryUsageDelegateField = IL2CPP.ResolveICall<Application.SimulateMemoryUsageDelegate>("UnityEngine.Application::SimulateMemoryUsage");
    Application.GetBuildTagsDelegateField = IL2CPP.ResolveICall<Application.GetBuildTagsDelegate>("UnityEngine.Application::GetBuildTags");
    Application.SetBuildTagsDelegateField = IL2CPP.ResolveICall<Application.SetBuildTagsDelegate>("UnityEngine.Application::SetBuildTags");
    Application.set_runInBackgroundDelegateField = IL2CPP.ResolveICall<Application.set_runInBackgroundDelegate>("UnityEngine.Application::set_runInBackground");
    Application.HasProLicenseDelegateField = IL2CPP.ResolveICall<Application.HasProLicenseDelegate>("UnityEngine.Application::HasProLicense");
    Application.get_isTestRunDelegateField = IL2CPP.ResolveICall<Application.get_isTestRunDelegate>("UnityEngine.Application::get_isTestRun");
    Application.get_isBuildingEditorResourcesDelegateField = IL2CPP.ResolveICall<Application.get_isBuildingEditorResourcesDelegate>("UnityEngine.Application::get_isBuildingEditorResources");
    Application.get_isHumanControllingUsDelegateField = IL2CPP.ResolveICall<Application.get_isHumanControllingUsDelegate>("UnityEngine.Application::get_isHumanControllingUs");
    Application.get_unityVersionMinDelegateField = IL2CPP.ResolveICall<Application.get_unityVersionMinDelegate>("UnityEngine.Application::get_unityVersionMin");
    Application.get_installModeDelegateField = IL2CPP.ResolveICall<Application.get_installModeDelegate>("UnityEngine.Application::get_installMode");
    Application.get_sandboxTypeDelegateField = IL2CPP.ResolveICall<Application.get_sandboxTypeDelegate>("UnityEngine.Application::get_sandboxType");
    Application.SetLogCallbackDefinedDelegateField = IL2CPP.ResolveICall<Application.SetLogCallbackDefinedDelegate>("UnityEngine.Application::SetLogCallbackDefined");
    Application.get_stackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.get_stackTraceLogTypeDelegate>("UnityEngine.Application::get_stackTraceLogType");
    Application.set_stackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.set_stackTraceLogTypeDelegate>("UnityEngine.Application::set_stackTraceLogType");
    Application.GetStackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.GetStackTraceLogTypeDelegate>("UnityEngine.Application::GetStackTraceLogType");
    Application.SetStackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.SetStackTraceLogTypeDelegate>("UnityEngine.Application::SetStackTraceLogType");
    Application.get_backgroundLoadingPriorityDelegateField = IL2CPP.ResolveICall<Application.get_backgroundLoadingPriorityDelegate>("UnityEngine.Application::get_backgroundLoadingPriority");
    Application.get_genuineDelegateField = IL2CPP.ResolveICall<Application.get_genuineDelegate>("UnityEngine.Application::get_genuine");
    Application.get_genuineCheckAvailableDelegateField = IL2CPP.ResolveICall<Application.get_genuineCheckAvailableDelegate>("UnityEngine.Application::get_genuineCheckAvailable");
    Application.HasUserAuthorizationDelegateField = IL2CPP.ResolveICall<Application.HasUserAuthorizationDelegate>("UnityEngine.Application::HasUserAuthorization");
    Application.get_submitAnalyticsDelegateField = IL2CPP.ResolveICall<Application.get_submitAnalyticsDelegate>("UnityEngine.Application::get_submitAnalytics");
    Application.get_internetReachabilityDelegateField = IL2CPP.ResolveICall<Application.get_internetReachabilityDelegate>("UnityEngine.Application::get_internetReachability");
    Application.CanStreamedLevelBeLoaded_InjectedDelegateField = IL2CPP.ResolveICall<Application.CanStreamedLevelBeLoaded_InjectedDelegate>("UnityEngine.Application::CanStreamedLevelBeLoaded_Injected");
    Application.IsPlaying_InjectedDelegateField = IL2CPP.ResolveICall<Application.IsPlaying_InjectedDelegate>("UnityEngine.Application::IsPlaying_Injected");
    Application.get_buildGUID_InjectedDelegateField = IL2CPP.ResolveICall<Application.get_buildGUID_InjectedDelegate>("UnityEngine.Application::get_buildGUID_Injected");
    Application.HasARGV_InjectedDelegateField = IL2CPP.ResolveICall<Application.HasARGV_InjectedDelegate>("UnityEngine.Application::HasARGV_Injected");
    Application.GetValueForARGV_InjectedDelegateField = IL2CPP.ResolveICall<Application.GetValueForARGV_InjectedDelegate>("UnityEngine.Application::GetValueForARGV_Injected");
    Application.get_temporaryCachePath_InjectedDelegateField = IL2CPP.ResolveICall<Application.get_temporaryCachePath_InjectedDelegate>("UnityEngine.Application::get_temporaryCachePath_Injected");
    Application.get_absoluteURL_InjectedDelegateField = IL2CPP.ResolveICall<Application.get_absoluteURL_InjectedDelegate>("UnityEngine.Application::get_absoluteURL_Injected");
    Application.Internal_ExternalCall_InjectedDelegateField = IL2CPP.ResolveICall<Application.Internal_ExternalCall_InjectedDelegate>("UnityEngine.Application::Internal_ExternalCall_Injected");
    Application.get_installerName_InjectedDelegateField = IL2CPP.ResolveICall<Application.get_installerName_InjectedDelegate>("UnityEngine.Application::get_installerName_Injected");
    Application.get_identifier_InjectedDelegateField = IL2CPP.ResolveICall<Application.get_identifier_InjectedDelegate>("UnityEngine.Application::get_identifier_Injected");
    Application.get_productName_InjectedDelegateField = IL2CPP.ResolveICall<Application.get_productName_InjectedDelegate>("UnityEngine.Application::get_productName_Injected");
    Application.get_companyName_InjectedDelegateField = IL2CPP.ResolveICall<Application.get_companyName_InjectedDelegate>("UnityEngine.Application::get_companyName_Injected");
    Application.get_cloudProjectId_InjectedDelegateField = IL2CPP.ResolveICall<Application.get_cloudProjectId_InjectedDelegate>("UnityEngine.Application::get_cloudProjectId_Injected");
    Application.get_consoleLogPath_InjectedDelegateField = IL2CPP.ResolveICall<Application.get_consoleLogPath_InjectedDelegate>("UnityEngine.Application::get_consoleLogPath_Injected");
    Application.RequestUserAuthorization_InjectedDelegateField = IL2CPP.ResolveICall<Application.RequestUserAuthorization_InjectedDelegate>("UnityEngine.Application::RequestUserAuthorization_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416878, XrefRangeEnd = 416880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Quit(int exitCode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &exitCode
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Quit_Public_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 416891, RefRangeEnd = 416893, XrefRangeStart = 416880, XrefRangeEnd = 416891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Quit()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Quit_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe bool isPlaying
  {
    [CallerCount(198), CachedScanResults(RefRangeStart = 416895, RefRangeEnd = 417093, XrefRangeStart = 416893, XrefRangeEnd = 416895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isPlaying_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe bool isFocused
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 417095, RefRangeEnd = 417099, XrefRangeStart = 417093, XrefRangeEnd = 417095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isFocused_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe bool runInBackground
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 417101, RefRangeEnd = 417103, XrefRangeStart = 417099, XrefRangeEnd = 417101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_runInBackground_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => Application.set_runInBackgroundDelegateField(value);
  }

  public static unsafe bool isBatchMode
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 417105, RefRangeEnd = 417106, XrefRangeStart = 417103, XrefRangeEnd = 417105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isBatchMode_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe string dataPath
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 417114, RefRangeEnd = 417121, XrefRangeStart = 417106, XrefRangeEnd = 417114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public static unsafe string streamingAssetsPath
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 417129, RefRangeEnd = 417138, XrefRangeStart = 417121, XrefRangeEnd = 417129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public static unsafe string persistentDataPath
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 417146, RefRangeEnd = 417151, XrefRangeStart = 417138, XrefRangeEnd = 417146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public static unsafe string unityVersion
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 417159, RefRangeEnd = 417162, XrefRangeStart = 417151, XrefRangeEnd = 417159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_unityVersion_Public_Static_get_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public static unsafe int unityVersionVer
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 417164, RefRangeEnd = 417165, XrefRangeStart = 417162, XrefRangeEnd = 417164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_unityVersionVer_Internal_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe int unityVersionMaj
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 417167, RefRangeEnd = 417168, XrefRangeStart = 417165, XrefRangeEnd = 417167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_unityVersionMaj_Internal_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe string version
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 417176, RefRangeEnd = 417180, XrefRangeStart = 417168, XrefRangeEnd = 417176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_version_Public_Static_get_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  [CallerCount(112 /*0x70*/)]
  [CachedScanResults(RefRangeStart = 417197, RefRangeEnd = 417309, XrefRangeStart = 417180, XrefRangeEnd = 417197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OpenURL(string url)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(url)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_OpenURL_Public_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int targetFrameRate
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 417311, RefRangeEnd = 417312, XrefRangeStart = 417309, XrefRangeEnd = 417311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_targetFrameRate_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 417314, RefRangeEnd = 417316, XrefRangeStart = 417312, XrefRangeEnd = 417314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_set_targetFrameRate_Public_Static_set_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe ThreadPriority backgroundLoadingPriority
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 417318, RefRangeEnd = 417320, XrefRangeStart = 417316, XrefRangeEnd = 417318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_set_backgroundLoadingPriority_Public_Static_set_Void_ThreadPriority_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => Application.get_backgroundLoadingPriorityDelegateField();
  }

  public static unsafe RuntimePlatform platform
  {
    [CallerCount(44), CachedScanResults(RefRangeStart = 417322, RefRangeEnd = 417366, XrefRangeStart = 417320, XrefRangeEnd = 417322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RuntimePlatform*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe SystemLanguage systemLanguage
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 417368, RefRangeEnd = 417369, XrefRangeStart = 417366, XrefRangeEnd = 417368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_systemLanguage_Public_Static_get_SystemLanguage_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(SystemLanguage*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417369, XrefRangeEnd = 417376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CallLowMemory(ApplicationMemoryUsage usage)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &usage
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_CallLowMemory_Internal_Static_Void_ApplicationMemoryUsage_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417376, XrefRangeEnd = 417380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HasLogCallback()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_HasLogCallback_Internal_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417380, XrefRangeEnd = 417387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CallLogCallback(
    string logString,
    string stackTrace,
    LogType type,
    bool invokedOnMainThread)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(logString);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &invokedOnMainThread;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_CallLogCallback_Private_Static_Void_String_String_LogType_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 417400, RefRangeEnd = 417401, XrefRangeStart = 417387, XrefRangeEnd = 417400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public static unsafe void add_focusChanged(Il2CppSystem.Action<bool> value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_add_focusChanged_Public_Static_add_Void_Action_1_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 417414, RefRangeEnd = 417416, XrefRangeStart = 417401, XrefRangeEnd = 417414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public static unsafe void remove_focusChanged(Il2CppSystem.Action<bool> value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_remove_focusChanged_Public_Static_rem_Void_Action_1_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417416, XrefRangeEnd = 417432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Internal_ApplicationWantsToQuit()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Internal_ApplicationWantsToQuit_Private_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe CancellationToken exitCancellationToken
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 417438, RefRangeEnd = 417440, XrefRangeStart = 417432, XrefRangeEnd = 417438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_exitCancellationToken_Public_Static_get_CancellationToken_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new CancellationToken(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417440, XrefRangeEnd = 417454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_InitializeExitCancellationToken()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Internal_InitializeExitCancellationToken_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417454, XrefRangeEnd = 417459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_RaiseExitCancellationToken()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Internal_RaiseExitCancellationToken_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417459, XrefRangeEnd = 417465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_ApplicationQuit()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Internal_ApplicationQuit_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417465, XrefRangeEnd = 417471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_ApplicationUnload()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Internal_ApplicationUnload_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417471, XrefRangeEnd = 417475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeOnBeforeRender()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_InvokeOnBeforeRender_Internal_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417475, XrefRangeEnd = 417481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeFocusChanged(bool focus)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &focus
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_InvokeFocusChanged_Internal_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417481, XrefRangeEnd = 417487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeDeepLinkActivated(string url)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(url)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_InvokeDeepLinkActivated_Internal_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe bool isEditor
  {
    [CallerCount(30), CachedScanResults(RefRangeStart = 274947, RefRangeEnd = 274977, XrefRangeStart = 274947, XrefRangeEnd = 274977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417487, XrefRangeEnd = 417489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_dataPath_Injected(out ManagedSpanWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref ret
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_dataPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417489, XrefRangeEnd = 417491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_streamingAssetsPath_Injected(out ManagedSpanWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref ret
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_streamingAssetsPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417491, XrefRangeEnd = 417493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_persistentDataPath_Injected(out ManagedSpanWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref ret
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_persistentDataPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417493, XrefRangeEnd = 417495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_unityVersion_Injected(out ManagedSpanWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref ret
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_unityVersion_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417495, XrefRangeEnd = 417497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_version_Injected(out ManagedSpanWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref ret
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_version_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417497, XrefRangeEnd = 417499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OpenURL_Injected(ref ManagedSpanWrapper url)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref url
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_OpenURL_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Application.LowMemoryCallback lowMemory
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_lowMemory, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Application.LowMemoryCallback) null : Il2CppObjectPool.Get<Application.LowMemoryCallback>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_lowMemory, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Application.MemoryUsageChangedCallback memoryUsageChanged
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_memoryUsageChanged, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Application.MemoryUsageChangedCallback) null : Il2CppObjectPool.Get<Application.MemoryUsageChangedCallback>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_memoryUsageChanged, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Application.LogCallback s_LogCallbackHandler
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_s_LogCallbackHandler, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Application.LogCallback) null : Il2CppObjectPool.Get<Application.LogCallback>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_s_LogCallbackHandler, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Application.LogCallback s_LogCallbackHandlerThreaded
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_s_LogCallbackHandlerThreaded, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Application.LogCallback) null : Il2CppObjectPool.Get<Application.LogCallback>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_s_LogCallbackHandlerThreaded, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppSystem.Action<bool> focusChanged
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_focusChanged, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<bool>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_focusChanged, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppSystem.Action<string> deepLinkActivated
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_deepLinkActivated, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<string>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<string>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_deepLinkActivated, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppSystem.Func<bool> wantsToQuit
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_wantsToQuit, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_wantsToQuit, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppSystem.Action quitting
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_quitting, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_quitting, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppSystem.Action unloading
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_unloading, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_unloading, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe CancellationTokenSource s_currentCancellationTokenSource
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_s_currentCancellationTokenSource, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (CancellationTokenSource) null : Il2CppObjectPool.Get<CancellationTokenSource>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_s_currentCancellationTokenSource, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static void CancelQuit() => Application.CancelQuitDelegateField();

  public static void Unload() => Application.UnloadDelegateField();

  public static bool isLoadingLevel => Application.get_isLoadingLevelDelegateField();

  public static void SimulateMemoryUsage(ApplicationMemoryUsage usage)
  {
    Application.SimulateMemoryUsageDelegateField(usage);
  }

  public static float GetStreamProgressForLevel(int levelIndex)
  {
    return levelIndex >= 0 && levelIndex < SceneManager.sceneCountInBuildSettings ? 1f : 0.0f;
  }

  public static float GetStreamProgressForLevel(string levelName) => 1f;

  public static int streamedBytes => 0;

  public static bool webSecurityEnabled => false;

  public static bool CanStreamedLevelBeLoaded(int levelIndex)
  {
    return levelIndex >= 0 && levelIndex < SceneManager.sceneCountInBuildSettings;
  }

  public static unsafe bool CanStreamedLevelBeLoaded(string levelName)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(levelName, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = levelName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return Application.CanStreamedLevelBeLoaded_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static bool IsPlaying(Object obj)
  {
    if ((object) obj == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) obj, nameof (obj));
    System.IntPtr num = Object.MarshalledUnityObject.MarshalNotNull<Object>(obj);
    if (num == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) obj, nameof (obj));
    return Application.IsPlaying_Injected(num);
  }

  public static Il2CppStringArray GetBuildTags()
  {
    System.IntPtr num = Application.GetBuildTagsDelegateField();
    return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
  }

  public static void SetBuildTags(Il2CppStringArray buildTags)
  {
    Application.SetBuildTagsDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buildTags));
  }

  public static string buildGUID
  {
    get
    {
      ManagedSpanWrapper ret;
      string stringAndDispose;
      try
      {
        Application.get_buildGUID_Injected(out ret);
      }
      finally
      {
        stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
      }
      return stringAndDispose;
    }
  }

  public static bool HasProLicense() => Application.HasProLicenseDelegateField();

  public static bool isTestRun => Application.get_isTestRunDelegateField();

  public static bool isBuildingEditorResources
  {
    get => Application.get_isBuildingEditorResourcesDelegateField();
  }

  public static bool isHumanControllingUs => Application.get_isHumanControllingUsDelegateField();

  public static unsafe bool HasARGV(string name)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = name.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return Application.HasARGV_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static unsafe string GetValueForARGV(string name)
  {
    ManagedSpanWrapper ret;
    string stringAndDispose;
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = name.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      Application.GetValueForARGV_Injected(ref managedSpanWrapper, out ret);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
    }
    return stringAndDispose;
  }

  public static string temporaryCachePath
  {
    get
    {
      ManagedSpanWrapper ret;
      string stringAndDispose;
      try
      {
        Application.get_temporaryCachePath_Injected(out ret);
      }
      finally
      {
        stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
      }
      return stringAndDispose;
    }
  }

  public static string absoluteURL
  {
    get
    {
      ManagedSpanWrapper ret;
      string stringAndDispose;
      try
      {
        Application.get_absoluteURL_Injected(out ret);
      }
      finally
      {
        stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
      }
      return stringAndDispose;
    }
  }

  public static void ExternalEval(string script)
  {
    if (script.Length > 0 && script[script.Length - 1] != ';')
      script = Il2CppSystem.String.Concat(script, ";");
    Application.Internal_ExternalCall(script);
  }

  public static unsafe void Internal_ExternalCall(string script)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(script, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = script.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      Application.Internal_ExternalCall_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static int unityVersionMin => Application.get_unityVersionMinDelegateField();

  public static string installerName
  {
    get
    {
      ManagedSpanWrapper ret;
      string stringAndDispose;
      try
      {
        Application.get_installerName_Injected(out ret);
      }
      finally
      {
        stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
      }
      return stringAndDispose;
    }
  }

  public static string identifier
  {
    get
    {
      ManagedSpanWrapper ret;
      string stringAndDispose;
      try
      {
        Application.get_identifier_Injected(out ret);
      }
      finally
      {
        stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
      }
      return stringAndDispose;
    }
  }

  public static ApplicationInstallMode installMode => Application.get_installModeDelegateField();

  public static ApplicationSandboxType sandboxType => Application.get_sandboxTypeDelegateField();

  public static string productName
  {
    get
    {
      ManagedSpanWrapper ret;
      string stringAndDispose;
      try
      {
        Application.get_productName_Injected(out ret);
      }
      finally
      {
        stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
      }
      return stringAndDispose;
    }
  }

  public static string companyName
  {
    get
    {
      ManagedSpanWrapper ret;
      string stringAndDispose;
      try
      {
        Application.get_companyName_Injected(out ret);
      }
      finally
      {
        stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
      }
      return stringAndDispose;
    }
  }

  public static string cloudProjectId
  {
    get
    {
      ManagedSpanWrapper ret;
      string stringAndDispose;
      try
      {
        Application.get_cloudProjectId_Injected(out ret);
      }
      finally
      {
        stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
      }
      return stringAndDispose;
    }
  }

  public static void ForceCrash(int mode) => Utils.ForceCrash((ForcedCrashCategory) mode);

  public static void SetLogCallbackDefined(bool defined)
  {
    Application.SetLogCallbackDefinedDelegateField(defined);
  }

  public static StackTraceLogType stackTraceLogType
  {
    get => Application.get_stackTraceLogTypeDelegateField();
    set => Application.set_stackTraceLogTypeDelegateField(value);
  }

  public static StackTraceLogType GetStackTraceLogType(LogType logType)
  {
    return Application.GetStackTraceLogTypeDelegateField(logType);
  }

  public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType)
  {
    Application.SetStackTraceLogTypeDelegateField(logType, stackTraceType);
  }

  public static string consoleLogPath
  {
    get
    {
      ManagedSpanWrapper ret;
      string stringAndDispose;
      try
      {
        Application.get_consoleLogPath_Injected(out ret);
      }
      finally
      {
        stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
      }
      return stringAndDispose;
    }
  }

  public static bool genuine => Application.get_genuineDelegateField();

  public static bool genuineCheckAvailable => Application.get_genuineCheckAvailableDelegateField();

  public static AsyncOperation RequestUserAuthorization(UserAuthorization mode)
  {
    System.IntPtr ptr = Application.RequestUserAuthorization_Injected(mode);
    return ptr != System.IntPtr.Zero ? AsyncOperation.BindingsMarshaller.ConvertToManaged(ptr) : (AsyncOperation) null;
  }

  public static bool HasUserAuthorization(UserAuthorization mode)
  {
    return Application.HasUserAuthorizationDelegateField(mode);
  }

  public static bool submitAnalytics => Application.get_submitAnalyticsDelegateField();

  public static bool isShowingSplashScreen => !SplashScreen.isFinished;

  public static bool isMobilePlatform
  {
    get
    {
      switch (Application.platform)
      {
        case RuntimePlatform.IPhonePlayer:
        case RuntimePlatform.Android:
        case RuntimePlatform.VisionOS:
          return true;
        case RuntimePlatform.MetroPlayerX86:
        case RuntimePlatform.MetroPlayerX64:
        case RuntimePlatform.MetroPlayerARM:
          return SystemInfo.deviceType == DeviceType.Handheld;
        default:
          return false;
      }
    }
  }

  public static bool isConsolePlatform
  {
    get
    {
      RuntimePlatform platform = Application.platform;
      int num;
      switch (platform)
      {
        case RuntimePlatform.PS4:
        case RuntimePlatform.Switch:
        case RuntimePlatform.GameCoreXboxSeries:
        case RuntimePlatform.GameCoreXboxOne:
        case RuntimePlatform.PS5:
        case RuntimePlatform.Switch2:
          num = 1;
          break;
        default:
          num = platform == RuntimePlatform.XboxOne ? 1 : 0;
          break;
      }
      return num != 0;
    }
  }

  public static NetworkReachability internetReachability
  {
    get => Application.get_internetReachabilityDelegateField();
  }

  [SpecialName]
  public static void add_lowMemory(Application.LowMemoryCallback value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_lowMemory(Application.LowMemoryCallback value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_memoryUsageChanged(Application.MemoryUsageChangedCallback value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_memoryUsageChanged(Application.MemoryUsageChangedCallback value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_logMessageReceived(Application.LogCallback value)
  {
    Application.s_LogCallbackHandler = Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) Application.s_LogCallbackHandler, (Il2CppSystem.Delegate) value).Cast<Application.LogCallback>();
    Application.SetLogCallbackDefined(true);
  }

  [SpecialName]
  public static void remove_logMessageReceived(Application.LogCallback value)
  {
    Application.s_LogCallbackHandler = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) Application.s_LogCallbackHandler, (Il2CppSystem.Delegate) value).Cast<Application.LogCallback>();
  }

  [SpecialName]
  public static void add_logMessageReceivedThreaded(Application.LogCallback value)
  {
    Application.s_LogCallbackHandlerThreaded = Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) Application.s_LogCallbackHandlerThreaded, (Il2CppSystem.Delegate) value).Cast<Application.LogCallback>();
    Application.SetLogCallbackDefined(true);
  }

  [SpecialName]
  public static void remove_logMessageReceivedThreaded(Application.LogCallback value)
  {
    Application.s_LogCallbackHandlerThreaded = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) Application.s_LogCallbackHandlerThreaded, (Il2CppSystem.Delegate) value).Cast<Application.LogCallback>();
  }

  public static void InvokeOnAdvertisingIdentifierCallback(
    string advertisingId,
    bool trackingEnabled)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static string ObjectToJSString(Il2CppSystem.Object o)
  {
    if (o == null)
      return "null";
    if (o.TryCast<string>() != null)
      return Il2CppSystem.String.Concat("\"", o.ToString().Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n").Replace("\r", "\\r").Replace("\0", "").Replace("\u2028", "").Replace("\u2029", ""), "\"");
    int num1;
    switch (o)
    {
      case int _:
      case short _:
      case uint _:
      case ushort _:
        num1 = 1;
        break;
      default:
        num1 = o is byte ? 1 : 0;
        break;
    }
    if (num1 != 0)
      return o.ToString();
    switch (o)
    {
      case float num2:
        NumberFormatInfo numberFormat1 = CultureInfo.InvariantCulture.NumberFormat;
        return num2.ToString((Il2CppSystem.IFormatProvider) numberFormat1);
      case double num3:
        NumberFormatInfo numberFormat2 = CultureInfo.InvariantCulture.NumberFormat;
        return num3.ToString((Il2CppSystem.IFormatProvider) numberFormat2);
      case char ch:
        return ch == '"' ? "\"\\\"\"" : Il2CppSystem.String.Concat("\"", o.ToString(), "\"");
      default:
        if (o.TryCast<IList>() == null)
          return Application.ObjectToJSString((Il2CppSystem.Object) o.ToString());
        IList ilist = o.Cast<IList>();
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("new Array(");
        int count = ((ICollection) ilist).Count;
        for (int index = 0; index < count; ++index)
        {
          if (index != 0)
            stringBuilder.Append(", ");
          stringBuilder.Append(Application.ObjectToJSString(ilist[index]));
        }
        stringBuilder.Append(")");
        return stringBuilder.ToString();
    }
  }

  public static void ExternalCall(string functionName, Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    Application.Internal_ExternalCall(Application.BuildInvocationForArguments(functionName, args));
  }

  public static void ExternalCall(string functionName, params Il2CppSystem.Object[] args)
  {
    Application.ExternalCall(functionName, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  public static string BuildInvocationForArguments(
    string functionName,
    Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static string BuildInvocationForArguments(string functionName, params Il2CppSystem.Object[] args)
  {
    return Application.BuildInvocationForArguments(functionName, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  public static bool isPlayer => !Application.isEditor;

  public static void DontDestroyOnLoad(Object o)
  {
    if (!(o != (Object) null))
      return;
    Object.DontDestroyOnLoad(o);
  }

  public static void CaptureScreenshot(string filename, int superSize)
  {
    throw new Il2CppSystem.NotSupportedException("Application.CaptureScreenshot is obsolete. Use ScreenCapture.CaptureScreenshot instead.");
  }

  public static void CaptureScreenshot(string filename)
  {
    throw new Il2CppSystem.NotSupportedException("Application.CaptureScreenshot is obsolete. Use ScreenCapture.CaptureScreenshot instead.");
  }

  [SpecialName]
  public static void add_onBeforeRender(UnityAction value)
  {
    BeforeRenderHelper.RegisterCallback(value);
  }

  [SpecialName]
  public static void remove_onBeforeRender(UnityAction value)
  {
    BeforeRenderHelper.UnregisterCallback(value);
  }

  [SpecialName]
  public static void add_deepLinkActivated(Il2CppSystem.Action<string> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_deepLinkActivated(Il2CppSystem.Action<string> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_wantsToQuit(Il2CppSystem.Func<bool> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_wantsToQuit(Il2CppSystem.Func<bool> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_quitting(Il2CppSystem.Action value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_quitting(Il2CppSystem.Action value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_unloading(Il2CppSystem.Action value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_unloading(Il2CppSystem.Action value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void RegisterLogCallback(Application.LogCallback handler)
  {
    Application.RegisterLogCallback(handler, false);
  }

  public static void RegisterLogCallbackThreaded(Application.LogCallback handler)
  {
    Application.RegisterLogCallback(handler, true);
  }

  public static void RegisterLogCallback(Application.LogCallback handler, bool threaded)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static int levelCount => SceneManager.sceneCountInBuildSettings;

  public static int loadedLevel => SceneManager.GetActiveScene().buildIndex;

  public static string loadedLevelName => SceneManager.GetActiveScene().name;

  public static void LoadLevel(int index) => SceneManager.LoadScene(index, LoadSceneMode.Single);

  public static void LoadLevel(string name) => SceneManager.LoadScene(name, LoadSceneMode.Single);

  public static void LoadLevelAdditive(int index)
  {
    SceneManager.LoadScene(index, LoadSceneMode.Additive);
  }

  public static void LoadLevelAdditive(string name)
  {
    SceneManager.LoadScene(name, LoadSceneMode.Additive);
  }

  public static AsyncOperation LoadLevelAsync(int index)
  {
    return SceneManager.LoadSceneAsync(index, LoadSceneMode.Single);
  }

  public static AsyncOperation LoadLevelAsync(string levelName)
  {
    return SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Single);
  }

  public static AsyncOperation LoadLevelAdditiveAsync(int index)
  {
    return SceneManager.LoadSceneAsync(index, LoadSceneMode.Additive);
  }

  public static AsyncOperation LoadLevelAdditiveAsync(string levelName)
  {
    return SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
  }

  public static bool UnloadLevel(int index) => SceneManager.UnloadScene(index);

  public static bool UnloadLevel(string scenePath) => SceneManager.UnloadScene(scenePath);

  public static bool CanStreamedLevelBeLoaded_Injected(ref ManagedSpanWrapper levelName)
  {
    return Application.CanStreamedLevelBeLoaded_InjectedDelegateField((System.IntPtr) ref levelName);
  }

  public static bool IsPlaying_Injected(System.IntPtr obj)
  {
    return Application.IsPlaying_InjectedDelegateField(obj);
  }

  public static void get_buildGUID_Injected(out ManagedSpanWrapper ret)
  {
    Application.get_buildGUID_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static bool HasARGV_Injected(ref ManagedSpanWrapper name)
  {
    return Application.HasARGV_InjectedDelegateField((System.IntPtr) ref name);
  }

  public static void GetValueForARGV_Injected(
    ref ManagedSpanWrapper name,
    out ManagedSpanWrapper ret)
  {
    Application.GetValueForARGV_InjectedDelegateField((System.IntPtr) ref name, (System.IntPtr) ref ret);
  }

  public static void get_temporaryCachePath_Injected(out ManagedSpanWrapper ret)
  {
    Application.get_temporaryCachePath_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void get_absoluteURL_Injected(out ManagedSpanWrapper ret)
  {
    Application.get_absoluteURL_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void Internal_ExternalCall_Injected(ref ManagedSpanWrapper script)
  {
    Application.Internal_ExternalCall_InjectedDelegateField((System.IntPtr) ref script);
  }

  public static void get_installerName_Injected(out ManagedSpanWrapper ret)
  {
    Application.get_installerName_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void get_identifier_Injected(out ManagedSpanWrapper ret)
  {
    Application.get_identifier_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void get_productName_Injected(out ManagedSpanWrapper ret)
  {
    Application.get_productName_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void get_companyName_Injected(out ManagedSpanWrapper ret)
  {
    Application.get_companyName_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void get_cloudProjectId_Injected(out ManagedSpanWrapper ret)
  {
    Application.get_cloudProjectId_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void get_consoleLogPath_Injected(out ManagedSpanWrapper ret)
  {
    Application.get_consoleLogPath_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static System.IntPtr RequestUserAuthorization_Injected(UserAuthorization mode)
  {
    return Application.RequestUserAuthorization_InjectedDelegateField(mode);
  }

  public sealed class LowMemoryCallback(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

    static LowMemoryCallback()
    {
      Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Application>.NativeClassPtr, nameof (LowMemoryCallback));
      Application.LowMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr, 100663895);
      Application.LowMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr, 100663896);
    }

    [CallerCount(483)]
    [CachedScanResults(RefRangeStart = 231718, RefRangeEnd = 232201, XrefRangeStart = 231718, XrefRangeEnd = 232201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LowMemoryCallback(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Application.LowMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Application.LowMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator Application.LowMemoryCallback([In] System.Action obj0)
    {
      return DelegateSupport.ConvertDelegate<Application.LowMemoryCallback>((System.Delegate) obj0);
    }

    public static Application.LowMemoryCallback operator +(
      [In] Application.LowMemoryCallback obj0,
      [In] Application.LowMemoryCallback obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<Application.LowMemoryCallback>();
    }

    public static Application.LowMemoryCallback operator -(
      [In] Application.LowMemoryCallback obj0,
      [In] Application.LowMemoryCallback obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (Application.LowMemoryCallback) @delegate : @delegate.Cast<Application.LowMemoryCallback>();
    }
  }

  public sealed class MemoryUsageChangedCallback(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ApplicationMemoryUsageChange_0;

    static MemoryUsageChangedCallback()
    {
      Il2CppClassPointerStore<Application.MemoryUsageChangedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Application>.NativeClassPtr, nameof (MemoryUsageChangedCallback));
      Application.MemoryUsageChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.MemoryUsageChangedCallback>.NativeClassPtr, 100663897);
      Application.MemoryUsageChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ApplicationMemoryUsageChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.MemoryUsageChangedCallback>.NativeClassPtr, 100663898);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 416874, RefRangeEnd = 416875, XrefRangeStart = 416871, XrefRangeEnd = 416874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MemoryUsageChangedCallback(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Application.MemoryUsageChangedCallback>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Application.MemoryUsageChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke([In] ref ApplicationMemoryUsageChange usage)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) ref usage
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Application.MemoryUsageChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ApplicationMemoryUsageChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public sealed class LogCallback(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_LogType_0;

    static LogCallback()
    {
      Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Application>.NativeClassPtr, nameof (LogCallback));
      Application.LogCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr, 100663899);
      Application.LogCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr, 100663900);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416875, XrefRangeEnd = 416878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LogCallback(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Application.LogCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(string condition, string stackTrace, LogType type)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(condition);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Application.LogCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator Application.LogCallback([In] System.Action<string, string, LogType> obj0)
    {
      return DelegateSupport.ConvertDelegate<Application.LogCallback>((System.Delegate) obj0);
    }

    public static Application.LogCallback operator +(
      [In] Application.LogCallback obj0,
      [In] Application.LogCallback obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<Application.LogCallback>();
    }

    public static Application.LogCallback operator -(
      [In] Application.LogCallback obj0,
      [In] Application.LogCallback obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (Application.LogCallback) @delegate : @delegate.Cast<Application.LogCallback>();
    }
  }

  private delegate void CancelQuitDelegate();

  private delegate void UnloadDelegate();

  private delegate bool get_isLoadingLevelDelegate();

  private delegate void SimulateMemoryUsageDelegate(ApplicationMemoryUsage usage);

  private delegate System.IntPtr GetBuildTagsDelegate();

  private delegate void SetBuildTagsDelegate(System.IntPtr buildTags);

  private delegate void set_runInBackgroundDelegate(bool value);

  private delegate bool HasProLicenseDelegate();

  private delegate bool get_isTestRunDelegate();

  private delegate bool get_isBuildingEditorResourcesDelegate();

  private delegate bool get_isHumanControllingUsDelegate();

  private delegate int get_unityVersionMinDelegate();

  private delegate ApplicationInstallMode get_installModeDelegate();

  private delegate ApplicationSandboxType get_sandboxTypeDelegate();

  private delegate void SetLogCallbackDefinedDelegate(bool defined);

  private delegate StackTraceLogType get_stackTraceLogTypeDelegate();

  private delegate void set_stackTraceLogTypeDelegate(StackTraceLogType value);

  private delegate StackTraceLogType GetStackTraceLogTypeDelegate(LogType logType);

  private delegate void SetStackTraceLogTypeDelegate(
    LogType logType,
    StackTraceLogType stackTraceType);

  private delegate ThreadPriority get_backgroundLoadingPriorityDelegate();

  private delegate bool get_genuineDelegate();

  private delegate bool get_genuineCheckAvailableDelegate();

  private delegate bool HasUserAuthorizationDelegate(UserAuthorization mode);

  private delegate bool get_submitAnalyticsDelegate();

  private delegate NetworkReachability get_internetReachabilityDelegate();

  private delegate bool CanStreamedLevelBeLoaded_InjectedDelegate(System.IntPtr levelName);

  private delegate bool IsPlaying_InjectedDelegate(System.IntPtr obj);

  private delegate void get_buildGUID_InjectedDelegate([Out] System.IntPtr ret);

  private delegate bool HasARGV_InjectedDelegate(System.IntPtr name);

  private delegate void GetValueForARGV_InjectedDelegate(System.IntPtr name, [Out] System.IntPtr ret);

  private delegate void get_temporaryCachePath_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void get_absoluteURL_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void Internal_ExternalCall_InjectedDelegate(System.IntPtr script);

  private delegate void get_installerName_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void get_identifier_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void get_productName_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void get_companyName_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void get_cloudProjectId_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void get_consoleLogPath_InjectedDelegate([Out] System.IntPtr ret);

  private delegate System.IntPtr RequestUserAuthorization_InjectedDelegate(UserAuthorization mode);
}
