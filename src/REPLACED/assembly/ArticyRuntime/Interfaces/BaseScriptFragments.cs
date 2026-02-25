// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Interfaces.BaseScriptFragments
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity.Interfaces;

public class BaseScriptFragments(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Logger;
  private static readonly System.IntPtr NativeFieldInfoPtr_ModelStringRepSeparator;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ModelToStringRepresentation_Internal_Static_String_ArticyObject_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ModelToStringRepresentation_Internal_Static_String_ArticyRef_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ModelToStringRepresentationAutoInstanceId_Internal_Static_String_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ModelToStringRepresentationAutoInstanceId_Internal_Static_String_ArticyRef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ModelToStringRepresentation_Private_Static_String_UInt64_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ModelRepToFields_Internal_Static_Void_String_byref_UInt64_byref_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StringToModelRep_Internal_Static_ArticyObject_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StringToModelRep_Internal_Static_ArticyObject_String_byref_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ObjectToModelRep_Public_Static_ArticyObject_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CallInstruction_Public_Virtual_New_Void_IGlobalVariables_UInt32_IBaseScriptMethodProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CallCondition_Public_Virtual_New_Boolean_IGlobalVariables_UInt32_IBaseScriptMethodProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getObj_Public_ScriptObjectProxy_IGlobalVariables_IBaseScriptMethodProvider_String_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setProp_Public_Void_IGlobalVariables_IBaseScriptMethodProvider_Object_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getProp_Protected_ScriptDataProxy_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getProp_Protected_ScriptDataProxy_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getProp_Protected_ScriptDataProxy_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_incrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_incrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_incrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_incrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_incrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_incrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_decrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_decrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_decrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_decrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_decrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_decrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_String_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_Object_String_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_Object_String_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_isInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_isInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_isInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_String_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getSeenCounter_Protected_Int32_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getSeenCounter_Protected_Int32_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getSeenCounter_Protected_Int32_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setSeenCounter_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setSeenCounter_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setSeenCounter_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_resetAllSeenCounters_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_fallback_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_fallback_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_fallback_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_fallback_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_random_Protected_Int32_IGlobalVariables_IBaseScriptMethodProvider_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_random_Protected_Int32_IGlobalVariables_IBaseScriptMethodProvider_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_random_Protected_Single_IGlobalVariables_IBaseScriptMethodProvider_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_random_Protected_Single_IGlobalVariables_IBaseScriptMethodProvider_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_print_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_Object_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetFromDataProxy_Private_IPropertyProvider_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static BaseScriptFragments()
  {
    Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Interfaces", nameof (BaseScriptFragments));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr);
    BaseScriptFragments.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, nameof (Logger));
    BaseScriptFragments.NativeFieldInfoPtr_ModelStringRepSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, nameof (ModelStringRepSeparator));
    BaseScriptFragments.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664457);
    BaseScriptFragments.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664458);
    BaseScriptFragments.NativeMethodInfoPtr_ModelToStringRepresentation_Internal_Static_String_ArticyObject_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664459);
    BaseScriptFragments.NativeMethodInfoPtr_ModelToStringRepresentation_Internal_Static_String_ArticyRef_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664460);
    BaseScriptFragments.NativeMethodInfoPtr_ModelToStringRepresentationAutoInstanceId_Internal_Static_String_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664461);
    BaseScriptFragments.NativeMethodInfoPtr_ModelToStringRepresentationAutoInstanceId_Internal_Static_String_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664462);
    BaseScriptFragments.NativeMethodInfoPtr_ModelToStringRepresentation_Private_Static_String_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664463);
    BaseScriptFragments.NativeMethodInfoPtr_ModelRepToFields_Internal_Static_Void_String_byref_UInt64_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664464 /*0x06000490*/);
    BaseScriptFragments.NativeMethodInfoPtr_StringToModelRep_Internal_Static_ArticyObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664465);
    BaseScriptFragments.NativeMethodInfoPtr_StringToModelRep_Internal_Static_ArticyObject_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664466);
    BaseScriptFragments.NativeMethodInfoPtr_ObjectToModelRep_Public_Static_ArticyObject_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664467);
    BaseScriptFragments.NativeMethodInfoPtr_CallInstruction_Public_Virtual_New_Void_IGlobalVariables_UInt32_IBaseScriptMethodProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664468);
    BaseScriptFragments.NativeMethodInfoPtr_CallCondition_Public_Virtual_New_Boolean_IGlobalVariables_UInt32_IBaseScriptMethodProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664469);
    BaseScriptFragments.NativeMethodInfoPtr_getObj_Public_ScriptObjectProxy_IGlobalVariables_IBaseScriptMethodProvider_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664470);
    BaseScriptFragments.NativeMethodInfoPtr_setProp_Public_Void_IGlobalVariables_IBaseScriptMethodProvider_Object_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664471);
    BaseScriptFragments.NativeMethodInfoPtr_getProp_Protected_ScriptDataProxy_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664472);
    BaseScriptFragments.NativeMethodInfoPtr_getProp_Protected_ScriptDataProxy_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664473);
    BaseScriptFragments.NativeMethodInfoPtr_getProp_Protected_ScriptDataProxy_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664474);
    BaseScriptFragments.NativeMethodInfoPtr_incrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664475);
    BaseScriptFragments.NativeMethodInfoPtr_incrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664476);
    BaseScriptFragments.NativeMethodInfoPtr_incrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664477);
    BaseScriptFragments.NativeMethodInfoPtr_incrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664478);
    BaseScriptFragments.NativeMethodInfoPtr_incrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664479);
    BaseScriptFragments.NativeMethodInfoPtr_incrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664480 /*0x060004A0*/);
    BaseScriptFragments.NativeMethodInfoPtr_decrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664481);
    BaseScriptFragments.NativeMethodInfoPtr_decrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664482);
    BaseScriptFragments.NativeMethodInfoPtr_decrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664483);
    BaseScriptFragments.NativeMethodInfoPtr_decrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664484);
    BaseScriptFragments.NativeMethodInfoPtr_decrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664485);
    BaseScriptFragments.NativeMethodInfoPtr_decrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664486);
    BaseScriptFragments.NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664487);
    BaseScriptFragments.NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664488);
    BaseScriptFragments.NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664489);
    BaseScriptFragments.NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664490);
    BaseScriptFragments.NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664491);
    BaseScriptFragments.NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_Object_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664492);
    BaseScriptFragments.NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664493);
    BaseScriptFragments.NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664494);
    BaseScriptFragments.NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_Object_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664495);
    BaseScriptFragments.NativeMethodInfoPtr_isInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664496 /*0x060004B0*/);
    BaseScriptFragments.NativeMethodInfoPtr_isInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664497);
    BaseScriptFragments.NativeMethodInfoPtr_isInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664498);
    BaseScriptFragments.NativeMethodInfoPtr_getSeenCounter_Protected_Int32_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664499);
    BaseScriptFragments.NativeMethodInfoPtr_getSeenCounter_Protected_Int32_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664500);
    BaseScriptFragments.NativeMethodInfoPtr_getSeenCounter_Protected_Int32_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664501);
    BaseScriptFragments.NativeMethodInfoPtr_setSeenCounter_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664502);
    BaseScriptFragments.NativeMethodInfoPtr_setSeenCounter_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664503);
    BaseScriptFragments.NativeMethodInfoPtr_setSeenCounter_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664504);
    BaseScriptFragments.NativeMethodInfoPtr_resetAllSeenCounters_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664505);
    BaseScriptFragments.NativeMethodInfoPtr_fallback_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664506);
    BaseScriptFragments.NativeMethodInfoPtr_fallback_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664507);
    BaseScriptFragments.NativeMethodInfoPtr_fallback_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664508);
    BaseScriptFragments.NativeMethodInfoPtr_fallback_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664509);
    BaseScriptFragments.NativeMethodInfoPtr_random_Protected_Int32_IGlobalVariables_IBaseScriptMethodProvider_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664510);
    BaseScriptFragments.NativeMethodInfoPtr_random_Protected_Int32_IGlobalVariables_IBaseScriptMethodProvider_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664511);
    BaseScriptFragments.NativeMethodInfoPtr_random_Protected_Single_IGlobalVariables_IBaseScriptMethodProvider_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664512 /*0x060004C0*/);
    BaseScriptFragments.NativeMethodInfoPtr_random_Protected_Single_IGlobalVariables_IBaseScriptMethodProvider_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664513);
    BaseScriptFragments.NativeMethodInfoPtr_print_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664514);
    BaseScriptFragments.NativeMethodInfoPtr_GetTargetFromDataProxy_Private_IPropertyProvider_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664515);
    BaseScriptFragments.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr, 100664516);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseScriptFragments.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnAfterDeserialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseScriptFragments.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999596, XrefRangeEnd = 999601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ModelToStringRepresentation(ArticyObject aObject, uint aInstanceId = 0)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_ModelToStringRepresentation_Internal_Static_String_ArticyObject_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999601, XrefRangeEnd = 999606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ModelToStringRepresentation(ArticyRef aObject, uint aInstanceId = 0)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_ModelToStringRepresentation_Internal_Static_String_ArticyRef_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999606, XrefRangeEnd = 999611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ModelToStringRepresentationAutoInstanceId(ArticyObject aObject)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObject)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_ModelToStringRepresentationAutoInstanceId_Internal_Static_String_ArticyObject_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 999616, RefRangeEnd = 999617, XrefRangeStart = 999611, XrefRangeEnd = 999616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ModelToStringRepresentationAutoInstanceId(ArticyRef aObject)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObject)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_ModelToStringRepresentationAutoInstanceId_Internal_Static_String_ArticyRef_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 999625, RefRangeEnd = 999631, XrefRangeStart = 999617, XrefRangeEnd = 999625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ModelToStringRepresentation(ulong aId, uint aInstanceId = 0)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_ModelToStringRepresentation_Private_Static_String_UInt64_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999631, XrefRangeEnd = 999637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ModelRepToFields(string aStr, out ulong aId, out uint aInstanceId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aStr);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aInstanceId;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_ModelRepToFields_Internal_Static_Void_String_byref_UInt64_byref_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 999641, RefRangeEnd = 999644, XrefRangeStart = 999637, XrefRangeEnd = 999641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyObject StringToModelRep(string aStr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aStr)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_StringToModelRep_Internal_Static_ArticyObject_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 999658, RefRangeEnd = 999663, XrefRangeStart = 999644, XrefRangeEnd = 999658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyObject StringToModelRep(string aStr, out uint aInstanceId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aStr);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_StringToModelRep_Internal_Static_ArticyObject_String_byref_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 999680, RefRangeEnd = 999683, XrefRangeStart = 999663, XrefRangeEnd = 999680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyObject ObjectToModelRep(Il2CppSystem.Object aObj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_ObjectToModelRep_Public_Static_ArticyObject_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void CallInstruction(
    IGlobalVariables aGlobalVariables,
    uint aHandlerId,
    IBaseScriptMethodProvider aMethodProvider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aHandlerId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseScriptFragments.NativeMethodInfoPtr_CallInstruction_Public_Virtual_New_Void_IGlobalVariables_UInt32_IBaseScriptMethodProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 67746, RefRangeEnd = 67757, XrefRangeStart = 67746, XrefRangeEnd = 67757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool CallCondition(
    IGlobalVariables aGlobalVariables,
    uint aHandlerId,
    IBaseScriptMethodProvider aMethodProvider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aHandlerId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseScriptFragments.NativeMethodInfoPtr_CallCondition_Public_Virtual_New_Boolean_IGlobalVariables_UInt32_IBaseScriptMethodProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999683, XrefRangeEnd = 999698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptObjectProxy getObj(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    string aTechnicalName,
    uint aInstanceId = 0)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aTechnicalName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_getObj_Public_ScriptObjectProxy_IGlobalVariables_IBaseScriptMethodProvider_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptObjectProxy) null : Il2CppObjectPool.Get<ScriptObjectProxy>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 999730, RefRangeEnd = 999732, XrefRangeStart = 999698, XrefRangeEnd = 999730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void setProp(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    Il2CppSystem.Object aTarget,
    string aProperty,
    Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_setProp_Public_Void_IGlobalVariables_IBaseScriptMethodProvider_Object_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999732, XrefRangeEnd = 999734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptDataProxy getProp(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptDataProxy aTarget,
    string aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_getProp_Protected_ScriptDataProxy_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999734, XrefRangeEnd = 999739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptDataProxy getProp(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptObjectProxy aTarget,
    string aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_getProp_Protected_ScriptDataProxy_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 999741, RefRangeEnd = 999748, XrefRangeStart = 999739, XrefRangeEnd = 999741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptDataProxy getProp(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    IPropertyProvider aTarget,
    string aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_getProp_Protected_ScriptDataProxy_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999748, XrefRangeEnd = 999750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void incrementProp(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptDataProxy aTarget,
    string aProperty,
    int aValue = 1)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_incrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999750, XrefRangeEnd = 999755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void incrementProp(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptObjectProxy aTarget,
    string aProperty,
    int aValue = 1)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_incrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 999770, RefRangeEnd = 999775, XrefRangeStart = 999755, XrefRangeEnd = 999770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void incrementProp(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    IPropertyProvider aTarget,
    string aProperty,
    int aValue = 1)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_incrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999775, XrefRangeEnd = 999777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void incrementProp(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptDataProxy aTarget,
    string aProperty,
    float aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_incrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999777, XrefRangeEnd = 999782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void incrementProp(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptObjectProxy aTarget,
    string aProperty,
    float aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_incrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 999792, RefRangeEnd = 999797, XrefRangeStart = 999782, XrefRangeEnd = 999792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void incrementProp(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    IPropertyProvider aTarget,
    string aProperty,
    float aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_incrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999797, XrefRangeEnd = 999799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void decrementProp(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptDataProxy aTarget,
    string aProperty,
    int aValue = 1)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_decrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999799, XrefRangeEnd = 999804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void decrementProp(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptObjectProxy aTarget,
    string aProperty,
    int aValue = 1)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_decrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999804, XrefRangeEnd = 999805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void decrementProp(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    IPropertyProvider aTarget,
    string aProperty,
    int aValue = 1)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_decrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999805, XrefRangeEnd = 999807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void decrementProp(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptDataProxy aTarget,
    string aProperty,
    float aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_decrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999807, XrefRangeEnd = 999812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void decrementProp(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptObjectProxy aTarget,
    string aProperty,
    float aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_decrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999812, XrefRangeEnd = 999813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void decrementProp(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    IPropertyProvider aTarget,
    string aProperty,
    float aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_decrementProp_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999813, XrefRangeEnd = 999815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool isPropInRange(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptDataProxy aTarget,
    string aProperty,
    int aLowerBound,
    int aUpperBound)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aLowerBound;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &aUpperBound;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999815, XrefRangeEnd = 999820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool isPropInRange(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptObjectProxy aTarget,
    string aProperty,
    int aLowerBound,
    int aUpperBound)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aLowerBound;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &aUpperBound;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 999832, RefRangeEnd = 999834, XrefRangeStart = 999820, XrefRangeEnd = 999832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool isPropInRange(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    IPropertyProvider aTarget,
    string aProperty,
    int aLowerBound,
    int aUpperBound)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aLowerBound;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &aUpperBound;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999834, XrefRangeEnd = 999836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool isPropInRange(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptDataProxy aTarget,
    string aProperty,
    float aLowerBound,
    float aUpperBound)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aLowerBound;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &aUpperBound;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999836, XrefRangeEnd = 999841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool isPropInRange(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptObjectProxy aTarget,
    string aProperty,
    float aLowerBound,
    float aUpperBound)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aLowerBound;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &aUpperBound;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 999853, RefRangeEnd = 999855, XrefRangeStart = 999841, XrefRangeEnd = 999853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool isPropInRange(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    Il2CppSystem.Object aTarget,
    string aProperty,
    float aLowerBound,
    float aUpperBound)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aLowerBound;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &aUpperBound;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_Object_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999855, XrefRangeEnd = 999857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool isPropInRange(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptDataProxy aTarget,
    string aProperty,
    string aLowerBound,
    string aUpperBound)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aLowerBound);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aUpperBound);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999857, XrefRangeEnd = 999862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool isPropInRange(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptObjectProxy aTarget,
    string aProperty,
    string aLowerBound,
    string aUpperBound)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aLowerBound);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aUpperBound);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 999876, RefRangeEnd = 999878, XrefRangeStart = 999862, XrefRangeEnd = 999876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool isPropInRange(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    Il2CppSystem.Object aTarget,
    string aProperty,
    string aLowerBound,
    string aUpperBound)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aLowerBound);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aUpperBound);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_isPropInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_Object_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe bool isInRange(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    int aValue,
    int aLowerBound,
    int aUpperBound)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &aLowerBound;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aUpperBound;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_isInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe bool isInRange(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    float aValue,
    float aLowerBound,
    float aUpperBound)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &aLowerBound;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aUpperBound;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_isInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999878, XrefRangeEnd = 999879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool isInRange(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    string aValue,
    string aLowerBound,
    string aUpperBound)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aValue);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aLowerBound);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aUpperBound);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_isInRange_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999879, XrefRangeEnd = 999881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int getSeenCounter(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptDataProxy aTarget)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_getSeenCounter_Protected_Int32_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999881, XrefRangeEnd = 999886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int getSeenCounter(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptObjectProxy aTarget)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_getSeenCounter_Protected_Int32_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 999898, RefRangeEnd = 999900, XrefRangeStart = 999886, XrefRangeEnd = 999898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int getSeenCounter(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    IPropertyProvider aTarget)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_getSeenCounter_Protected_Int32_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999900, XrefRangeEnd = 999902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void setSeenCounter(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptDataProxy aTarget,
    int aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_setSeenCounter_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999902, XrefRangeEnd = 999907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void setSeenCounter(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptObjectProxy aTarget,
    int aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_setSeenCounter_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 999925, RefRangeEnd = 999927, XrefRangeStart = 999907, XrefRangeEnd = 999925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void setSeenCounter(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    IPropertyProvider aTarget,
    int aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_setSeenCounter_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999927, XrefRangeEnd = 999931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void resetAllSeenCounters(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_resetAllSeenCounters_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999931, XrefRangeEnd = 999936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool fallback(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_fallback_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999936, XrefRangeEnd = 999944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool fallback(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptDataProxy aOriginNode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOriginNode);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_fallback_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptDataProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999944, XrefRangeEnd = 999954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool fallback(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    ScriptObjectProxy aOriginNode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOriginNode);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_fallback_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_ScriptObjectProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999954, XrefRangeEnd = 999961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool fallback(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    IPropertyProvider aOriginNode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOriginNode);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_fallback_Protected_Boolean_IGlobalVariables_IBaseScriptMethodProvider_IPropertyProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999961, XrefRangeEnd = 999962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int random(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    int aMin,
    int aMax)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aMin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &aMax;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_random_Protected_Int32_IGlobalVariables_IBaseScriptMethodProvider_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999962, XrefRangeEnd = 999963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int random(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    int aMax)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aMax;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_random_Protected_Int32_IGlobalVariables_IBaseScriptMethodProvider_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999963, XrefRangeEnd = 999964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float random(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    float aMin,
    float aMax)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aMin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &aMax;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_random_Protected_Single_IGlobalVariables_IBaseScriptMethodProvider_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999964, XrefRangeEnd = 999965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float random(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    float aMax)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aMax;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_random_Protected_Single_IGlobalVariables_IBaseScriptMethodProvider_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999965, XrefRangeEnd = 999993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void print(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    Il2CppSystem.Object aMessage,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aParams)
  {
    if (aParams == null)
      aParams = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMessage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParams);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_print_Protected_Void_IGlobalVariables_IBaseScriptMethodProvider_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 1000008, RefRangeEnd = 1000019, XrefRangeStart = 999993, XrefRangeEnd = 1000008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IPropertyProvider GetTargetFromDataProxy(ScriptDataProxy aTarget)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr_GetTargetFromDataProxy_Private_IPropertyProvider_ScriptDataProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IPropertyProvider) null : Il2CppObjectPool.Get<IPropertyProvider>(num3);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BaseScriptFragments()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseScriptFragments>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseScriptFragments.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public void print(
    IGlobalVariables aGlobalVariables,
    IBaseScriptMethodProvider aMethodProvider,
    Il2CppSystem.Object aMessage,
    params Il2CppSystem.Object[] aParams)
  {
    this.print(aGlobalVariables, aMethodProvider, aMessage, new Il2CppReferenceArray<Il2CppSystem.Object>(aParams));
  }

  public static unsafe ArticyLogger Logger
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(BaseScriptFragments.NativeFieldInfoPtr_Logger, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ArticyLogger) null : Il2CppObjectPool.Get<ArticyLogger>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BaseScriptFragments.NativeFieldInfoPtr_Logger, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe char ModelStringRepSeparator
  {
    get
    {
      char stringRepSeparator;
      IL2CPP.il2cpp_field_static_get_value(BaseScriptFragments.NativeFieldInfoPtr_ModelStringRepSeparator, (void*) &stringRepSeparator);
      return stringRepSeparator;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BaseScriptFragments.NativeFieldInfoPtr_ModelStringRepSeparator, (void*) &value);
    }
  }
}
