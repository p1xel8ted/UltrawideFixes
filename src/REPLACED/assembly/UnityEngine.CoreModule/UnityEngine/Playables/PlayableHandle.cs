// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.PlayableHandle
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct PlayableHandle
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Version;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Null;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetObject_Internal_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayableOfType_Internal_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInput_Internal_Playable_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetInputWeight_Internal_Boolean_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInputWeight_Internal_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableHandle_PlayableHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableHandle_PlayableHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Internal_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayableType_Internal_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetScriptInstance_Internal_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayState_Internal_PlayState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSpeed_Internal_Void_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTime_Internal_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTime_Internal_Void_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsDone_Internal_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetDone_Internal_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDuration_Internal_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetDuration_Internal_Void_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPropagateSetTime_Internal_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGraph_Internal_PlayableGraph_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInputCount_Internal_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetInputCount_Internal_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetInputWeight_Internal_Void_PlayableHandle_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPreviousTime_Internal_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTraversalMode_Internal_Void_PlayableTraversalMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeWrapMode_Internal_DirectorWrapMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTimeWrapMode_Internal_Void_DirectorWrapMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetScriptInstance_Private_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInputHandle_Private_PlayableHandle_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetInputWeightFromIndex_Private_Void_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInputWeightFromIndex_Private_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGraph_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableGraph_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetInputWeight_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableHandle_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInputHandle_Injected_Private_Static_Void_byref_PlayableHandle_Int32_byref_PlayableHandle_0;
  [FieldOffset(0)]
  public System.IntPtr m_Handle;
  [FieldOffset(8)]
  public uint m_Version;
  private static readonly PlayableHandle.IsNullDelegate IsNullDelegateField;
  private static readonly PlayableHandle.GetJobTypeDelegate GetJobTypeDelegateField;
  private static readonly PlayableHandle.CanChangeInputsDelegate CanChangeInputsDelegateField;
  private static readonly PlayableHandle.CanSetWeightsDelegate CanSetWeightsDelegateField;
  private static readonly PlayableHandle.CanDestroyDelegate CanDestroyDelegateField;
  private static readonly PlayableHandle.GetSpeedDelegate GetSpeedDelegateField;
  private static readonly PlayableHandle.GetPropagateSetTimeDelegate GetPropagateSetTimeDelegateField;
  private static readonly PlayableHandle.GetOutputPortFromInputIndexDelegate GetOutputPortFromInputIndexDelegateField;
  private static readonly PlayableHandle.GetInputPortFromOutputIndexDelegate GetInputPortFromOutputIndexDelegateField;
  private static readonly PlayableHandle.GetOutputCountDelegate GetOutputCountDelegateField;
  private static readonly PlayableHandle.SetOutputCountDelegate SetOutputCountDelegateField;
  private static readonly PlayableHandle.SetDelayDelegate SetDelayDelegateField;
  private static readonly PlayableHandle.GetDelayDelegate GetDelayDelegateField;
  private static readonly PlayableHandle.IsDelayedDelegate IsDelayedDelegateField;
  private static readonly PlayableHandle.SetLeadTimeDelegate SetLeadTimeDelegateField;
  private static readonly PlayableHandle.GetLeadTimeDelegate GetLeadTimeDelegateField;
  private static readonly PlayableHandle.GetTraversalModeDelegate GetTraversalModeDelegateField;
  private static readonly PlayableHandle.GetJobDataDelegate GetJobDataDelegateField;
  private static readonly PlayableHandle.GetOutputHandle_InjectedDelegate GetOutputHandle_InjectedDelegateField;

  static PlayableHandle()
  {
    Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", nameof (PlayableHandle));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr);
    PlayableHandle.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, nameof (m_Handle));
    PlayableHandle.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, nameof (m_Version));
    PlayableHandle.NativeFieldInfoPtr_m_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, nameof (m_Null));
    PlayableHandle.NativeMethodInfoPtr_GetObject_Internal_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669471);
    PlayableHandle.NativeMethodInfoPtr_IsPlayableOfType_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669472);
    PlayableHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669473);
    PlayableHandle.NativeMethodInfoPtr_GetInput_Internal_Playable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669474);
    PlayableHandle.NativeMethodInfoPtr_SetInputWeight_Internal_Boolean_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669475);
    PlayableHandle.NativeMethodInfoPtr_GetInputWeight_Internal_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669476);
    PlayableHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableHandle_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669477);
    PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669478);
    PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669479);
    PlayableHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669480);
    PlayableHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableHandle_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669481);
    PlayableHandle.NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669482);
    PlayableHandle.NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669483);
    PlayableHandle.NativeMethodInfoPtr_IsValid_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669484);
    PlayableHandle.NativeMethodInfoPtr_GetPlayableType_Internal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669485);
    PlayableHandle.NativeMethodInfoPtr_SetScriptInstance_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669486);
    PlayableHandle.NativeMethodInfoPtr_GetPlayState_Internal_PlayState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669487);
    PlayableHandle.NativeMethodInfoPtr_Play_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669488);
    PlayableHandle.NativeMethodInfoPtr_Pause_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669489);
    PlayableHandle.NativeMethodInfoPtr_SetSpeed_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669490);
    PlayableHandle.NativeMethodInfoPtr_GetTime_Internal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669491);
    PlayableHandle.NativeMethodInfoPtr_SetTime_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669492);
    PlayableHandle.NativeMethodInfoPtr_IsDone_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669493);
    PlayableHandle.NativeMethodInfoPtr_SetDone_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669494);
    PlayableHandle.NativeMethodInfoPtr_GetDuration_Internal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669495);
    PlayableHandle.NativeMethodInfoPtr_SetDuration_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669496);
    PlayableHandle.NativeMethodInfoPtr_SetPropagateSetTime_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669497);
    PlayableHandle.NativeMethodInfoPtr_GetGraph_Internal_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669498);
    PlayableHandle.NativeMethodInfoPtr_GetInputCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669499);
    PlayableHandle.NativeMethodInfoPtr_SetInputCount_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669500);
    PlayableHandle.NativeMethodInfoPtr_SetInputWeight_Internal_Void_PlayableHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669501);
    PlayableHandle.NativeMethodInfoPtr_GetPreviousTime_Internal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669502);
    PlayableHandle.NativeMethodInfoPtr_SetTraversalMode_Internal_Void_PlayableTraversalMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669503);
    PlayableHandle.NativeMethodInfoPtr_GetTimeWrapMode_Internal_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669504);
    PlayableHandle.NativeMethodInfoPtr_SetTimeWrapMode_Internal_Void_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669505);
    PlayableHandle.NativeMethodInfoPtr_GetScriptInstance_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669506);
    PlayableHandle.NativeMethodInfoPtr_GetInputHandle_Private_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669507);
    PlayableHandle.NativeMethodInfoPtr_SetInputWeightFromIndex_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669508);
    PlayableHandle.NativeMethodInfoPtr_GetInputWeightFromIndex_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669509);
    PlayableHandle.NativeMethodInfoPtr_GetGraph_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669511);
    PlayableHandle.NativeMethodInfoPtr_SetInputWeight_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669512);
    PlayableHandle.NativeMethodInfoPtr_GetInputHandle_Injected_Private_Static_Void_byref_PlayableHandle_Int32_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100669513);
    PlayableHandle.IsNullDelegateField = IL2CPP.ResolveICall<PlayableHandle.IsNullDelegate>("UnityEngine.Playables.PlayableHandle::IsNull");
    PlayableHandle.GetJobTypeDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetJobTypeDelegate>("UnityEngine.Playables.PlayableHandle::GetJobType");
    PlayableHandle.CanChangeInputsDelegateField = IL2CPP.ResolveICall<PlayableHandle.CanChangeInputsDelegate>("UnityEngine.Playables.PlayableHandle::CanChangeInputs");
    PlayableHandle.CanSetWeightsDelegateField = IL2CPP.ResolveICall<PlayableHandle.CanSetWeightsDelegate>("UnityEngine.Playables.PlayableHandle::CanSetWeights");
    PlayableHandle.CanDestroyDelegateField = IL2CPP.ResolveICall<PlayableHandle.CanDestroyDelegate>("UnityEngine.Playables.PlayableHandle::CanDestroy");
    PlayableHandle.GetSpeedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetSpeedDelegate>("UnityEngine.Playables.PlayableHandle::GetSpeed");
    PlayableHandle.GetPropagateSetTimeDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetPropagateSetTimeDelegate>("UnityEngine.Playables.PlayableHandle::GetPropagateSetTime");
    PlayableHandle.GetOutputPortFromInputIndexDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetOutputPortFromInputIndexDelegate>("UnityEngine.Playables.PlayableHandle::GetOutputPortFromInputIndex");
    PlayableHandle.GetInputPortFromOutputIndexDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetInputPortFromOutputIndexDelegate>("UnityEngine.Playables.PlayableHandle::GetInputPortFromOutputIndex");
    PlayableHandle.GetOutputCountDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetOutputCountDelegate>("UnityEngine.Playables.PlayableHandle::GetOutputCount");
    PlayableHandle.SetOutputCountDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetOutputCountDelegate>("UnityEngine.Playables.PlayableHandle::SetOutputCount");
    PlayableHandle.SetDelayDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetDelayDelegate>("UnityEngine.Playables.PlayableHandle::SetDelay");
    PlayableHandle.GetDelayDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetDelayDelegate>("UnityEngine.Playables.PlayableHandle::GetDelay");
    PlayableHandle.IsDelayedDelegateField = IL2CPP.ResolveICall<PlayableHandle.IsDelayedDelegate>("UnityEngine.Playables.PlayableHandle::IsDelayed");
    PlayableHandle.SetLeadTimeDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetLeadTimeDelegate>("UnityEngine.Playables.PlayableHandle::SetLeadTime");
    PlayableHandle.GetLeadTimeDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetLeadTimeDelegate>("UnityEngine.Playables.PlayableHandle::GetLeadTime");
    PlayableHandle.GetTraversalModeDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetTraversalModeDelegate>("UnityEngine.Playables.PlayableHandle::GetTraversalMode");
    PlayableHandle.GetJobDataDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetJobDataDelegate>("UnityEngine.Playables.PlayableHandle::GetJobData");
    PlayableHandle.GetOutputHandle_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetOutputHandle_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetOutputHandle_Injected");
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 480581, RefRangeEnd = 480584, XrefRangeStart = 480570, XrefRangeEnd = 480581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe T GetObject<T>() where T : class
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.MethodInfoStoreGeneric_GetObject_Internal_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(20)]
  [CachedScanResults(RefRangeStart = 480602, RefRangeEnd = 480622, XrefRangeStart = 480584, XrefRangeEnd = 480602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsPlayableOfType<T>()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.MethodInfoStoreGeneric_IsPlayableOfType_Internal_Boolean_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe PlayableHandle Null
  {
    [CallerCount(35), CachedScanResults(RefRangeStart = 480626, RefRangeEnd = 480661, XrefRangeStart = 480622, XrefRangeEnd = 480626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(PlayableHandle*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480669, RefRangeEnd = 480670, XrefRangeStart = 480661, XrefRangeEnd = 480669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Playable GetInput(int inputPort)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inputPort
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInput_Internal_Playable_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Playable*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480677, RefRangeEnd = 480678, XrefRangeStart = 480670, XrefRangeEnd = 480677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool SetInputWeight(int inputIndex, float weight)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &inputIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &weight;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetInputWeight_Internal_Boolean_Int32_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480685, RefRangeEnd = 480686, XrefRangeStart = 480678, XrefRangeEnd = 480685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetInputWeight(int inputIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inputIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInputWeight_Internal_Single_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 480689, RefRangeEnd = 480702, XrefRangeStart = 480686, XrefRangeEnd = 480689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator ==(PlayableHandle x, PlayableHandle y)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableHandle_PlayableHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480702, XrefRangeEnd = 480710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object p)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480710, XrefRangeEnd = 480713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(PlayableHandle other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480713, XrefRangeEnd = 480715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableHandle_PlayableHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480715, XrefRangeEnd = 480719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckInputBounds(int inputIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inputIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 480724, RefRangeEnd = 480727, XrefRangeStart = 480719, XrefRangeEnd = 480724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckInputBounds(int inputIndex, bool acceptAny)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &inputIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &acceptAny;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(25)]
  [CachedScanResults(RefRangeStart = 480729, RefRangeEnd = 480754, XrefRangeStart = 480727, XrefRangeEnd = 480729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsValid()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_IsValid_Internal_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 480756, RefRangeEnd = 480759, XrefRangeStart = 480754, XrefRangeEnd = 480756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppSystem.Type GetPlayableType()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetPlayableType_Internal_Type_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 480761, RefRangeEnd = 480764, XrefRangeStart = 480759, XrefRangeEnd = 480761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetScriptInstance(Il2CppSystem.Object scriptInstance)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) scriptInstance)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetScriptInstance_Internal_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480766, RefRangeEnd = 480767, XrefRangeStart = 480764, XrefRangeEnd = 480766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayState GetPlayState()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetPlayState_Internal_PlayState_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayState*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480769, RefRangeEnd = 480771, XrefRangeStart = 480767, XrefRangeEnd = 480769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Play()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Play_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480773, RefRangeEnd = 480774, XrefRangeStart = 480771, XrefRangeEnd = 480773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Pause()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Pause_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480776, RefRangeEnd = 480777, XrefRangeStart = 480774, XrefRangeEnd = 480776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSpeed(double value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetSpeed_Internal_Void_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480779, RefRangeEnd = 480780, XrefRangeStart = 480777, XrefRangeEnd = 480779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe double GetTime()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetTime_Internal_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(double*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480782, RefRangeEnd = 480784, XrefRangeStart = 480780, XrefRangeEnd = 480782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetTime(double value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetTime_Internal_Void_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480786, RefRangeEnd = 480787, XrefRangeStart = 480784, XrefRangeEnd = 480786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsDone()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_IsDone_Internal_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480789, RefRangeEnd = 480791, XrefRangeStart = 480787, XrefRangeEnd = 480789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetDone(bool value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetDone_Internal_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480793, RefRangeEnd = 480795, XrefRangeStart = 480791, XrefRangeEnd = 480793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe double GetDuration()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetDuration_Internal_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(double*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 480797, RefRangeEnd = 480800, XrefRangeStart = 480795, XrefRangeEnd = 480797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetDuration(double value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetDuration_Internal_Void_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480802, RefRangeEnd = 480803, XrefRangeStart = 480800, XrefRangeEnd = 480802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPropagateSetTime(bool value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetPropagateSetTime_Internal_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480808, RefRangeEnd = 480809, XrefRangeStart = 480803, XrefRangeEnd = 480808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayableGraph GetGraph()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetGraph_Internal_PlayableGraph_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableGraph*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 480811, RefRangeEnd = 480814, XrefRangeStart = 480809, XrefRangeEnd = 480811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetInputCount()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInputCount_Internal_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 480816, RefRangeEnd = 480830, XrefRangeStart = 480814, XrefRangeEnd = 480816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetInputCount(int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetInputCount_Internal_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480835, RefRangeEnd = 480836, XrefRangeStart = 480830, XrefRangeEnd = 480835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetInputWeight(PlayableHandle input, float weight)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &input;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &weight;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetInputWeight_Internal_Void_PlayableHandle_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480838, RefRangeEnd = 480839, XrefRangeStart = 480836, XrefRangeEnd = 480838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe double GetPreviousTime()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetPreviousTime_Internal_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(double*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480843, RefRangeEnd = 480844, XrefRangeStart = 480839, XrefRangeEnd = 480843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetTraversalMode(PlayableTraversalMode mode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &mode
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetTraversalMode_Internal_Void_PlayableTraversalMode_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480846, RefRangeEnd = 480847, XrefRangeStart = 480844, XrefRangeEnd = 480846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DirectorWrapMode GetTimeWrapMode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetTimeWrapMode_Internal_DirectorWrapMode_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(DirectorWrapMode*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480849, RefRangeEnd = 480850, XrefRangeStart = 480847, XrefRangeEnd = 480849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetTimeWrapMode(DirectorWrapMode mode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &mode
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetTimeWrapMode_Internal_Void_DirectorWrapMode_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480852, RefRangeEnd = 480853, XrefRangeStart = 480850, XrefRangeEnd = 480852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppSystem.Object GetScriptInstance()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetScriptInstance_Private_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480853, XrefRangeEnd = 480858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayableHandle GetInputHandle(int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInputHandle_Private_PlayableHandle_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480858, XrefRangeEnd = 480860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetInputWeightFromIndex(int index, float weight)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &weight;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetInputWeightFromIndex_Private_Void_Int32_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480860, XrefRangeEnd = 480862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetInputWeightFromIndex(int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInputWeightFromIndex_Private_Single_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480862, XrefRangeEnd = 480864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetGraph_Injected(ref PlayableHandle _unity_self, out PlayableGraph ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetGraph_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableGraph_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480864, XrefRangeEnd = 480866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetInputWeight_Injected(
    ref PlayableHandle _unity_self,
    [In] ref PlayableHandle input,
    float weight)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &weight;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetInputWeight_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableHandle_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480866, XrefRangeEnd = 480868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetInputHandle_Injected(
    ref PlayableHandle _unity_self,
    int index,
    out PlayableHandle ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInputHandle_Injected_Private_Static_Void_byref_PlayableHandle_Int32_byref_PlayableHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe PlayableHandle m_Null
  {
    get
    {
      PlayableHandle mNull;
      IL2CPP.il2cpp_field_static_get_value(PlayableHandle.NativeFieldInfoPtr_m_Null, (void*) &mNull);
      return mNull;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlayableHandle.NativeFieldInfoPtr_m_Null, (void*) &value);
    }
  }

  public T GetPayload<T>() where T : struct
  {
    if (!this.IsValid())
      return default (T);
    Il2CppSystem.Object scriptInstance = this.GetScriptInstance();
    return scriptInstance == null ? default (T) : scriptInstance.Cast<T>();
  }

  public void SetPayload<T>(T payload) where T : struct
  {
    if (!this.IsValid())
      return;
    this.SetScriptInstance((Il2CppSystem.Object) (System.ValueType) payload);
  }

  public Playable GetOutput(int outputPort) => new Playable(this.GetOutputHandle(outputPort));

  public int GetOutputPortFromInputConnection(int inputPort)
  {
    return this.GetOutputPortFromInputIndex(inputPort);
  }

  public int GetInputPortFromOutputConnection(int inputPort)
  {
    return this.GetInputPortFromOutputIndex(inputPort);
  }

  public void Destroy() => this.GetGraph().DestroyPlayable<Playable>(new Playable(this));

  public static bool operator !=(PlayableHandle x, PlayableHandle y)
  {
    return !PlayableHandle.CompareVersion(x, y);
  }

  public bool IsNull()
  {
    return PlayableHandle.IsNullDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public Il2CppSystem.Type GetJobType()
  {
    System.IntPtr num = PlayableHandle.GetJobTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
    return num == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num);
  }

  public bool CanChangeInputs()
  {
    return PlayableHandle.CanChangeInputsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public bool CanSetWeights()
  {
    return PlayableHandle.CanSetWeightsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public bool CanDestroy()
  {
    return PlayableHandle.CanDestroyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public double GetSpeed()
  {
    return PlayableHandle.GetSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public bool GetPropagateSetTime()
  {
    return PlayableHandle.GetPropagateSetTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public int GetOutputPortFromInputIndex(int index)
  {
    return PlayableHandle.GetOutputPortFromInputIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this), index);
  }

  public int GetInputPortFromOutputIndex(int index)
  {
    return PlayableHandle.GetInputPortFromOutputIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this), index);
  }

  public int GetOutputCount()
  {
    return PlayableHandle.GetOutputCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public void SetOutputCount(int value)
  {
    PlayableHandle.SetOutputCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this), value);
  }

  public void SetDelay(double delay)
  {
    PlayableHandle.SetDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this), delay);
  }

  public double GetDelay()
  {
    return PlayableHandle.GetDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public bool IsDelayed()
  {
    return PlayableHandle.IsDelayedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public void SetLeadTime(float value)
  {
    PlayableHandle.SetLeadTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this), value);
  }

  public float GetLeadTime()
  {
    return PlayableHandle.GetLeadTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public PlayableTraversalMode GetTraversalMode()
  {
    return PlayableHandle.GetTraversalModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public System.IntPtr GetJobData()
  {
    return PlayableHandle.GetJobDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public PlayableHandle GetOutputHandle(int index)
  {
    PlayableHandle ret;
    PlayableHandle.GetOutputHandle_Injected(ref this, index, out ret);
    return ret;
  }

  public static void GetOutputHandle_Injected(
    ref PlayableHandle _unity_self,
    int index,
    out PlayableHandle ret)
  {
    PlayableHandle.GetOutputHandle_InjectedDelegateField((System.IntPtr) ref _unity_self, index, (System.IntPtr) ref ret);
  }

  private sealed class MethodInfoStoreGeneric_GetObject_Internal_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableHandle.NativeMethodInfoPtr_GetObject_Internal_T_0, Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_IsPlayableOfType_Internal_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableHandle.NativeMethodInfoPtr_IsPlayableOfType_Internal_Boolean_0, Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private delegate bool IsNullDelegate(System.IntPtr _param1);

  private delegate System.IntPtr GetJobTypeDelegate(System.IntPtr _param1);

  private delegate bool CanChangeInputsDelegate(System.IntPtr _param1);

  private delegate bool CanSetWeightsDelegate(System.IntPtr _param1);

  private delegate bool CanDestroyDelegate(System.IntPtr _param1);

  private delegate double GetSpeedDelegate(System.IntPtr _param1);

  private delegate bool GetPropagateSetTimeDelegate(System.IntPtr _param1);

  private delegate int GetOutputPortFromInputIndexDelegate(System.IntPtr _param1, int index);

  private delegate int GetInputPortFromOutputIndexDelegate(System.IntPtr _param1, int index);

  private delegate int GetOutputCountDelegate(System.IntPtr _param1);

  private delegate void SetOutputCountDelegate(System.IntPtr _param1, int value);

  private delegate void SetDelayDelegate(System.IntPtr _param1, double delay);

  private delegate double GetDelayDelegate(System.IntPtr _param1);

  private delegate bool IsDelayedDelegate(System.IntPtr _param1);

  private delegate void SetLeadTimeDelegate(System.IntPtr _param1, float value);

  private delegate float GetLeadTimeDelegate(System.IntPtr _param1);

  private delegate PlayableTraversalMode GetTraversalModeDelegate(System.IntPtr _param1);

  private delegate System.IntPtr GetJobDataDelegate(System.IntPtr _param1);

  private delegate void GetOutputHandle_InjectedDelegate(System.IntPtr _unity_self, int index, [Out] System.IntPtr ret);
}
