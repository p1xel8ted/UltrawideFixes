// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.PlayableGraph
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
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct PlayableGraph
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Version;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRootPlayable_Public_Playable_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Connect_Public_Boolean_U_Int32_V_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_PlayableGraph_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_PlayableGraph_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsPlaying_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTimeUpdateMode_Public_Void_DirectorUpdateMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetResolver_Public_IExposedPropertyTable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayableCount_Public_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRootPlayableCount_Public_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SynchronizeEvaluation_Internal_Void_PlayableGraph_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreatePlayableHandle_Internal_PlayableHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateScriptOutputInternal_Internal_Boolean_String_byref_PlayableOutputHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRootPlayableInternal_Internal_PlayableHandle_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsMatchFrameRateEnabled_Internal_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFrameRate_Internal_FrameRate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConnectInternal_Private_Boolean_PlayableHandle_Int32_PlayableHandle_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_PlayableGraph_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SynchronizeEvaluation_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableGraph_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreatePlayableHandle_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateScriptOutputInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_ManagedSpanWrapper_byref_PlayableOutputHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRootPlayableInternal_Injected_Private_Static_Void_byref_PlayableGraph_Int32_byref_PlayableHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFrameRate_Injected_Private_Static_Void_byref_PlayableGraph_byref_FrameRate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConnectInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_Int32_byref_PlayableHandle_Int32_0;
  [FieldOffset(0)]
  public System.IntPtr m_Handle;
  [FieldOffset(8)]
  public uint m_Version;
  private static readonly PlayableGraph.IsDoneDelegate IsDoneDelegateField;
  private static readonly PlayableGraph.GetTimeUpdateModeDelegate GetTimeUpdateModeDelegateField;
  private static readonly PlayableGraph.SetResolverDelegate SetResolverDelegateField;
  private static readonly PlayableGraph.GetOutputCountDelegate GetOutputCountDelegateField;
  private static readonly PlayableGraph.DisableMatchFrameRateDelegate DisableMatchFrameRateDelegateField;
  private static readonly PlayableGraph.GetOutputInternalDelegate GetOutputInternalDelegateField;
  private static readonly PlayableGraph.GetOutputCountByTypeInternalDelegate GetOutputCountByTypeInternalDelegateField;
  private static readonly PlayableGraph.GetOutputByTypeInternalDelegate GetOutputByTypeInternalDelegateField;
  private static readonly PlayableGraph.DestroyOutputInternal_InjectedDelegate DestroyOutputInternal_InjectedDelegateField;
  private static readonly PlayableGraph.EnableMatchFrameRate_InjectedDelegate EnableMatchFrameRate_InjectedDelegateField;
  private static readonly PlayableGraph.DisconnectInternal_InjectedDelegate DisconnectInternal_InjectedDelegateField;
  private static readonly PlayableGraph.DestroyPlayableInternal_InjectedDelegate DestroyPlayableInternal_InjectedDelegateField;
  private static readonly PlayableGraph.DestroySubgraphInternal_InjectedDelegate DestroySubgraphInternal_InjectedDelegateField;

  static PlayableGraph()
  {
    Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", nameof (PlayableGraph));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr);
    PlayableGraph.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, nameof (m_Handle));
    PlayableGraph.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, nameof (m_Version));
    PlayableGraph.NativeMethodInfoPtr_GetRootPlayable_Public_Playable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669442);
    PlayableGraph.NativeMethodInfoPtr_Connect_Public_Boolean_U_Int32_V_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669443);
    PlayableGraph.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669444);
    PlayableGraph.NativeMethodInfoPtr_Create_Public_Static_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669445);
    PlayableGraph.NativeMethodInfoPtr_Create_Public_Static_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669446);
    PlayableGraph.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669447);
    PlayableGraph.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669448);
    PlayableGraph.NativeMethodInfoPtr_IsPlaying_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669449);
    PlayableGraph.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669450);
    PlayableGraph.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669451);
    PlayableGraph.NativeMethodInfoPtr_Evaluate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669452);
    PlayableGraph.NativeMethodInfoPtr_SetTimeUpdateMode_Public_Void_DirectorUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669453);
    PlayableGraph.NativeMethodInfoPtr_GetResolver_Public_IExposedPropertyTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669454);
    PlayableGraph.NativeMethodInfoPtr_GetPlayableCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669455);
    PlayableGraph.NativeMethodInfoPtr_GetRootPlayableCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669456);
    PlayableGraph.NativeMethodInfoPtr_SynchronizeEvaluation_Internal_Void_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669457);
    PlayableGraph.NativeMethodInfoPtr_CreatePlayableHandle_Internal_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669458);
    PlayableGraph.NativeMethodInfoPtr_CreateScriptOutputInternal_Internal_Boolean_String_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669459);
    PlayableGraph.NativeMethodInfoPtr_GetRootPlayableInternal_Internal_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669460);
    PlayableGraph.NativeMethodInfoPtr_IsMatchFrameRateEnabled_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669461);
    PlayableGraph.NativeMethodInfoPtr_GetFrameRate_Internal_FrameRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669462);
    PlayableGraph.NativeMethodInfoPtr_ConnectInternal_Private_Boolean_PlayableHandle_Int32_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669463);
    PlayableGraph.NativeMethodInfoPtr_Create_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669464);
    PlayableGraph.NativeMethodInfoPtr_SynchronizeEvaluation_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669465);
    PlayableGraph.NativeMethodInfoPtr_CreatePlayableHandle_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669466);
    PlayableGraph.NativeMethodInfoPtr_CreateScriptOutputInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_ManagedSpanWrapper_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669467);
    PlayableGraph.NativeMethodInfoPtr_GetRootPlayableInternal_Injected_Private_Static_Void_byref_PlayableGraph_Int32_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669468);
    PlayableGraph.NativeMethodInfoPtr_GetFrameRate_Injected_Private_Static_Void_byref_PlayableGraph_byref_FrameRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669469);
    PlayableGraph.NativeMethodInfoPtr_ConnectInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_Int32_byref_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100669470);
    PlayableGraph.IsDoneDelegateField = IL2CPP.ResolveICall<PlayableGraph.IsDoneDelegate>("UnityEngine.Playables.PlayableGraph::IsDone");
    PlayableGraph.GetTimeUpdateModeDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetTimeUpdateModeDelegate>("UnityEngine.Playables.PlayableGraph::GetTimeUpdateMode");
    PlayableGraph.SetResolverDelegateField = IL2CPP.ResolveICall<PlayableGraph.SetResolverDelegate>("UnityEngine.Playables.PlayableGraph::SetResolver");
    PlayableGraph.GetOutputCountDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputCountDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputCount");
    PlayableGraph.DisableMatchFrameRateDelegateField = IL2CPP.ResolveICall<PlayableGraph.DisableMatchFrameRateDelegate>("UnityEngine.Playables.PlayableGraph::DisableMatchFrameRate");
    PlayableGraph.GetOutputInternalDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputInternalDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputInternal");
    PlayableGraph.GetOutputCountByTypeInternalDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputCountByTypeInternalDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputCountByTypeInternal");
    PlayableGraph.GetOutputByTypeInternalDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputByTypeInternalDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputByTypeInternal");
    PlayableGraph.DestroyOutputInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DestroyOutputInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DestroyOutputInternal_Injected");
    PlayableGraph.EnableMatchFrameRate_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.EnableMatchFrameRate_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::EnableMatchFrameRate_Injected");
    PlayableGraph.DisconnectInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DisconnectInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DisconnectInternal_Injected");
    PlayableGraph.DestroyPlayableInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DestroyPlayableInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DestroyPlayableInternal_Injected");
    PlayableGraph.DestroySubgraphInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DestroySubgraphInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DestroySubgraphInternal_Injected");
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 480435, RefRangeEnd = 480440, XrefRangeStart = 480433, XrefRangeEnd = 480435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Playable GetRootPlayable(int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetRootPlayable_Public_Playable_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Playable*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480449, RefRangeEnd = 480450, XrefRangeStart = 480440, XrefRangeEnd = 480449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Connect<U, V>(
    U source,
    int sourceOutputPort,
    V destination,
    int destinationInputPort)
    where U : new()
    where V : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) source;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref source;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceOutputPort;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    V& local3;
    if (!typeof (V).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<V> local4 = (object) destination;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local3 = local4 is string ? (V&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (V&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
    }
    else
      local3 = ref destination;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &destinationInputPort;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.MethodInfoStoreGeneric_Connect_Public_Boolean_U_Int32_V_Int32_0<U, V>.Pointer, (System.IntPtr) ref this, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480452, RefRangeEnd = 480453, XrefRangeStart = 480450, XrefRangeEnd = 480452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Evaluate()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_Evaluate_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480454, RefRangeEnd = 480456, XrefRangeStart = 480453, XrefRangeEnd = 480454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PlayableGraph Create()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_Create_Public_Static_PlayableGraph_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableGraph*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480468, RefRangeEnd = 480470, XrefRangeStart = 480456, XrefRangeEnd = 480468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PlayableGraph Create(string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_Create_Public_Static_PlayableGraph_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableGraph*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480472, RefRangeEnd = 480474, XrefRangeStart = 480470, XrefRangeEnd = 480472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Destroy()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_Destroy_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 480476, RefRangeEnd = 480482, XrefRangeStart = 480474, XrefRangeEnd = 480476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsValid()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_IsValid_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 480484, RefRangeEnd = 480490, XrefRangeStart = 480482, XrefRangeEnd = 480484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsPlaying()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_IsPlaying_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 480492, RefRangeEnd = 480495, XrefRangeStart = 480490, XrefRangeEnd = 480492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Play()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_Play_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480497, RefRangeEnd = 480498, XrefRangeStart = 480495, XrefRangeEnd = 480497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Stop()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_Stop_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480498, XrefRangeEnd = 480500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Evaluate(float deltaTime)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &deltaTime
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_Evaluate_Public_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480502, RefRangeEnd = 480503, XrefRangeStart = 480500, XrefRangeEnd = 480502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetTimeUpdateMode(DirectorUpdateMode value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_SetTimeUpdateMode_Public_Void_DirectorUpdateMode_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 480505, RefRangeEnd = 480518, XrefRangeStart = 480503, XrefRangeEnd = 480505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IExposedPropertyTable GetResolver()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetResolver_Public_IExposedPropertyTable_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IExposedPropertyTable) null : Il2CppObjectPool.Get<IExposedPropertyTable>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480520, RefRangeEnd = 480521, XrefRangeStart = 480518, XrefRangeEnd = 480520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetPlayableCount()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetPlayableCount_Public_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480523, RefRangeEnd = 480525, XrefRangeStart = 480521, XrefRangeEnd = 480523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetRootPlayableCount()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetRootPlayableCount_Public_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480527, RefRangeEnd = 480528, XrefRangeStart = 480525, XrefRangeEnd = 480527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SynchronizeEvaluation(PlayableGraph playable)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &playable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_SynchronizeEvaluation_Internal_Void_PlayableGraph_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480530, RefRangeEnd = 480531, XrefRangeStart = 480528, XrefRangeEnd = 480530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayableHandle CreatePlayableHandle()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_CreatePlayableHandle_Internal_PlayableHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480543, RefRangeEnd = 480545, XrefRangeStart = 480531, XrefRangeEnd = 480543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CreateScriptOutputInternal(string name, out PlayableOutputHandle handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref handle;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_CreateScriptOutputInternal_Internal_Boolean_String_byref_PlayableOutputHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480545, XrefRangeEnd = 480547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayableHandle GetRootPlayableInternal(int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetRootPlayableInternal_Internal_PlayableHandle_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480549, RefRangeEnd = 480551, XrefRangeStart = 480547, XrefRangeEnd = 480549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsMatchFrameRateEnabled()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_IsMatchFrameRateEnabled_Internal_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480551, XrefRangeEnd = 480553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FrameRate GetFrameRate()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetFrameRate_Internal_FrameRate_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(FrameRate*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480555, RefRangeEnd = 480556, XrefRangeStart = 480553, XrefRangeEnd = 480555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ConnectInternal(
    PlayableHandle source,
    int sourceOutputPort,
    PlayableHandle destination,
    int destinationInputPort)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &source;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceOutputPort;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &destination;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &destinationInputPort;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_ConnectInternal_Private_Boolean_PlayableHandle_Int32_PlayableHandle_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480556, XrefRangeEnd = 480558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Create_Injected(ref ManagedSpanWrapper name, out PlayableGraph ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_Create_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_PlayableGraph_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480558, XrefRangeEnd = 480560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SynchronizeEvaluation_Injected(
    ref PlayableGraph _unity_self,
    [In] ref PlayableGraph playable)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref playable;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_SynchronizeEvaluation_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableGraph_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480560, XrefRangeEnd = 480562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreatePlayableHandle_Injected(
    ref PlayableGraph _unity_self,
    out PlayableHandle ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_CreatePlayableHandle_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480562, XrefRangeEnd = 480564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CreateScriptOutputInternal_Injected(
    ref PlayableGraph _unity_self,
    ref ManagedSpanWrapper name,
    out PlayableOutputHandle handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref handle;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_CreateScriptOutputInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_ManagedSpanWrapper_byref_PlayableOutputHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480564, XrefRangeEnd = 480566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetRootPlayableInternal_Injected(
    ref PlayableGraph _unity_self,
    int index,
    out PlayableHandle ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetRootPlayableInternal_Injected_Private_Static_Void_byref_PlayableGraph_Int32_byref_PlayableHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480566, XrefRangeEnd = 480568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetFrameRate_Injected(ref PlayableGraph _unity_self, out FrameRate ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetFrameRate_Injected_Private_Static_Void_byref_PlayableGraph_byref_FrameRate_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480568, XrefRangeEnd = 480570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ConnectInternal_Injected(
    ref PlayableGraph _unity_self,
    [In] ref PlayableHandle source,
    int sourceOutputPort,
    [In] ref PlayableHandle destination,
    int destinationInputPort)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref source;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceOutputPort;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref destination;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &destinationInputPort;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_ConnectInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_Int32_byref_PlayableHandle_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public void Disconnect<U>(U input, int inputPort) where U : struct
  {
    this.DisconnectInternal(input.GetHandle(), inputPort);
  }

  public void DestroyPlayable<U>(U playable) where U : struct
  {
    this.DestroyPlayableInternal(playable.GetHandle());
  }

  public void DestroySubgraph<U>(U playable) where U : struct
  {
    this.DestroySubgraphInternal(playable.GetHandle());
  }

  public void DestroyOutput<U>(U output) where U : struct
  {
    this.DestroyOutputInternal(output.GetHandle());
  }

  public int GetOutputCountByType<T>() where T : struct
  {
    return this.GetOutputCountByTypeInternal(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
  }

  public PlayableOutput GetOutput(int index)
  {
    PlayableOutputHandle handle;
    return !this.GetOutputInternal(index, out handle) ? PlayableOutput.Null : new PlayableOutput(handle);
  }

  public PlayableOutput GetOutputByType<T>(int index) where T : struct
  {
    PlayableOutputHandle handle;
    return !this.GetOutputByTypeInternal(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), index, out handle) ? PlayableOutput.Null : new PlayableOutput(handle);
  }

  public bool IsDone()
  {
    return PlayableGraph.IsDoneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public DirectorUpdateMode GetTimeUpdateMode()
  {
    return PlayableGraph.GetTimeUpdateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public void SetResolver(IExposedPropertyTable value)
  {
    PlayableGraph.SetResolverDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
  }

  public int GetOutputCount()
  {
    return PlayableGraph.GetOutputCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public void DestroyOutputInternal(PlayableOutputHandle handle)
  {
    PlayableGraph.DestroyOutputInternal_Injected(ref this, ref handle);
  }

  public void EnableMatchFrameRate(FrameRate frameRate)
  {
    PlayableGraph.EnableMatchFrameRate_Injected(ref this, ref frameRate);
  }

  public void DisableMatchFrameRate()
  {
    PlayableGraph.DisableMatchFrameRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public bool GetOutputInternal(int index, out PlayableOutputHandle handle)
  {
    return PlayableGraph.GetOutputInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this), index, (System.IntPtr) ref handle);
  }

  public int GetOutputCountByTypeInternal(Il2CppSystem.Type outputType)
  {
    return PlayableGraph.GetOutputCountByTypeInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outputType));
  }

  public bool GetOutputByTypeInternal(Il2CppSystem.Type outputType, int index, out PlayableOutputHandle handle)
  {
    return PlayableGraph.GetOutputByTypeInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outputType), index, (System.IntPtr) ref handle);
  }

  public void DisconnectInternal(PlayableHandle playable, int inputPort)
  {
    PlayableGraph.DisconnectInternal_Injected(ref this, ref playable, inputPort);
  }

  public void DestroyPlayableInternal(PlayableHandle playable)
  {
    PlayableGraph.DestroyPlayableInternal_Injected(ref this, ref playable);
  }

  public void DestroySubgraphInternal(PlayableHandle playable)
  {
    PlayableGraph.DestroySubgraphInternal_Injected(ref this, ref playable);
  }

  public static void DestroyOutputInternal_Injected(
    ref PlayableGraph _unity_self,
    [In] ref PlayableOutputHandle handle)
  {
    PlayableGraph.DestroyOutputInternal_InjectedDelegateField((System.IntPtr) ref _unity_self, (System.IntPtr) ref handle);
  }

  public static void EnableMatchFrameRate_Injected(
    ref PlayableGraph _unity_self,
    [In] ref FrameRate frameRate)
  {
    PlayableGraph.EnableMatchFrameRate_InjectedDelegateField((System.IntPtr) ref _unity_self, (System.IntPtr) ref frameRate);
  }

  public static void DisconnectInternal_Injected(
    ref PlayableGraph _unity_self,
    [In] ref PlayableHandle playable,
    int inputPort)
  {
    PlayableGraph.DisconnectInternal_InjectedDelegateField((System.IntPtr) ref _unity_self, (System.IntPtr) ref playable, inputPort);
  }

  public static void DestroyPlayableInternal_Injected(
    ref PlayableGraph _unity_self,
    [In] ref PlayableHandle playable)
  {
    PlayableGraph.DestroyPlayableInternal_InjectedDelegateField((System.IntPtr) ref _unity_self, (System.IntPtr) ref playable);
  }

  public static void DestroySubgraphInternal_Injected(
    ref PlayableGraph _unity_self,
    [In] ref PlayableHandle playable)
  {
    PlayableGraph.DestroySubgraphInternal_InjectedDelegateField((System.IntPtr) ref _unity_self, (System.IntPtr) ref playable);
  }

  private sealed class MethodInfoStoreGeneric_Connect_Public_Boolean_U_Int32_V_Int32_0<U, V>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableGraph.NativeMethodInfoPtr_Connect_Public_Boolean_U_Int32_V_Int32_0, Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
    }))));
  }

  private delegate bool IsDoneDelegate(System.IntPtr _param1);

  private delegate DirectorUpdateMode GetTimeUpdateModeDelegate(System.IntPtr _param1);

  private delegate void SetResolverDelegate(System.IntPtr _param1, System.IntPtr value);

  private delegate int GetOutputCountDelegate(System.IntPtr _param1);

  private delegate void DisableMatchFrameRateDelegate(System.IntPtr _param1);

  private delegate bool GetOutputInternalDelegate(System.IntPtr _param1, int index, [Out] System.IntPtr handle);

  private delegate int GetOutputCountByTypeInternalDelegate(System.IntPtr _param1, System.IntPtr outputType);

  private delegate bool GetOutputByTypeInternalDelegate(
    System.IntPtr _param1,
    System.IntPtr outputType,
    int index,
    [Out] System.IntPtr handle);

  private delegate void DestroyOutputInternal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr handle);

  private delegate void EnableMatchFrameRate_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr frameRate);

  private delegate void DisconnectInternal_InjectedDelegate(
    System.IntPtr _unity_self,
    [In] System.IntPtr playable,
    int inputPort);

  private delegate void DestroyPlayableInternal_InjectedDelegate(
    System.IntPtr _unity_self,
    [In] System.IntPtr playable);

  private delegate void DestroySubgraphInternal_InjectedDelegate(
    System.IntPtr _unity_self,
    [In] System.IntPtr playable);
}
