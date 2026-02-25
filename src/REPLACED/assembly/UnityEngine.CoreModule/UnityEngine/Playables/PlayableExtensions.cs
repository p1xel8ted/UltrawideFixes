// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.PlayableExtensions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

#nullable disable
namespace UnityEngine.Playables;

public static class PlayableExtensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_U_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGraph_Public_Static_PlayableGraph_U_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayState_Public_Static_PlayState_U_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Static_Void_U_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_U_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSpeed_Public_Static_Void_U_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetDuration_Public_Static_Void_U_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDuration_Public_Static_Double_U_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTime_Public_Static_Void_U_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTime_Public_Static_Double_U_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPreviousTime_Public_Static_Double_U_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsDone_Public_Static_Boolean_U_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPropagateSetTime_Public_Static_Void_U_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetInputCount_Public_Static_Void_U_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInputCount_Public_Static_Int32_U_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInput_Public_Static_Playable_U_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetInputWeight_Public_Static_Void_U_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetInputWeight_Public_Static_Void_U_V_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInputWeight_Public_Static_Single_U_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTraversalMode_Public_Static_Void_U_PlayableTraversalMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeWrapMode_Internal_Static_DirectorWrapMode_U_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTimeWrapMode_Internal_Static_Void_U_DirectorWrapMode_0;

  static PlayableExtensions()
  {
    Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", nameof (PlayableExtensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr);
    PlayableExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669420);
    PlayableExtensions.NativeMethodInfoPtr_GetGraph_Public_Static_PlayableGraph_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669421);
    PlayableExtensions.NativeMethodInfoPtr_GetPlayState_Public_Static_PlayState_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669422);
    PlayableExtensions.NativeMethodInfoPtr_Play_Public_Static_Void_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669423);
    PlayableExtensions.NativeMethodInfoPtr_Pause_Public_Static_Void_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669424);
    PlayableExtensions.NativeMethodInfoPtr_SetSpeed_Public_Static_Void_U_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669425);
    PlayableExtensions.NativeMethodInfoPtr_SetDuration_Public_Static_Void_U_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669426);
    PlayableExtensions.NativeMethodInfoPtr_GetDuration_Public_Static_Double_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669427);
    PlayableExtensions.NativeMethodInfoPtr_SetTime_Public_Static_Void_U_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669428);
    PlayableExtensions.NativeMethodInfoPtr_GetTime_Public_Static_Double_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669429);
    PlayableExtensions.NativeMethodInfoPtr_GetPreviousTime_Public_Static_Double_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669430);
    PlayableExtensions.NativeMethodInfoPtr_IsDone_Public_Static_Boolean_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669431);
    PlayableExtensions.NativeMethodInfoPtr_SetPropagateSetTime_Public_Static_Void_U_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669432);
    PlayableExtensions.NativeMethodInfoPtr_SetInputCount_Public_Static_Void_U_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669433);
    PlayableExtensions.NativeMethodInfoPtr_GetInputCount_Public_Static_Int32_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669434);
    PlayableExtensions.NativeMethodInfoPtr_GetInput_Public_Static_Playable_U_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669435);
    PlayableExtensions.NativeMethodInfoPtr_SetInputWeight_Public_Static_Void_U_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669436);
    PlayableExtensions.NativeMethodInfoPtr_SetInputWeight_Public_Static_Void_U_V_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669437);
    PlayableExtensions.NativeMethodInfoPtr_GetInputWeight_Public_Static_Single_U_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669438);
    PlayableExtensions.NativeMethodInfoPtr_SetTraversalMode_Public_Static_Void_U_PlayableTraversalMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669439);
    PlayableExtensions.NativeMethodInfoPtr_GetTimeWrapMode_Internal_Static_DirectorWrapMode_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669440 /*0x06001800*/);
    PlayableExtensions.NativeMethodInfoPtr_SetTimeWrapMode_Internal_Static_Void_U_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100669441);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 480137, RefRangeEnd = 480140, XrefRangeStart = 480129, XrefRangeEnd = 480137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsValid<U>(this U playable) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_IsValid_Public_Static_Boolean_U_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 480149, RefRangeEnd = 480160, XrefRangeStart = 480140, XrefRangeEnd = 480149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PlayableGraph GetGraph<U>(this U playable) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetGraph_Public_Static_PlayableGraph_U_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableGraph*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 480169, RefRangeEnd = 480172, XrefRangeStart = 480160, XrefRangeEnd = 480169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PlayState GetPlayState<U>(this U playable) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetPlayState_Public_Static_PlayState_U_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayState*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480181, RefRangeEnd = 480183, XrefRangeStart = 480172, XrefRangeEnd = 480181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Play<U>(this U playable) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_Play_Public_Static_Void_U_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 480192, RefRangeEnd = 480200, XrefRangeStart = 480183, XrefRangeEnd = 480192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Pause<U>(this U playable) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_Pause_Public_Static_Void_U_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 480209, RefRangeEnd = 480215, XrefRangeStart = 480200, XrefRangeEnd = 480209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetSpeed<U>(this U playable, double value) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetSpeed_Public_Static_Void_U_Double_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480223, RefRangeEnd = 480225, XrefRangeStart = 480215, XrefRangeEnd = 480223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetDuration<U>(this U playable, double value) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetDuration_Public_Static_Void_U_Double_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480233, RefRangeEnd = 480234, XrefRangeStart = 480225, XrefRangeEnd = 480233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe double GetDuration<U>(this U playable) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetDuration_Public_Static_Double_U_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(double*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 480243, RefRangeEnd = 480252, XrefRangeStart = 480234, XrefRangeEnd = 480243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetTime<U>(this U playable, double value) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetTime_Public_Static_Void_U_Double_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480260, RefRangeEnd = 480262, XrefRangeStart = 480252, XrefRangeEnd = 480260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe double GetTime<U>(this U playable) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetTime_Public_Static_Double_U_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(double*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480271, RefRangeEnd = 480273, XrefRangeStart = 480262, XrefRangeEnd = 480271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe double GetPreviousTime<U>(this U playable) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetPreviousTime_Public_Static_Double_U_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(double*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480282, RefRangeEnd = 480283, XrefRangeStart = 480273, XrefRangeEnd = 480282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsDone<U>(this U playable) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_IsDone_Public_Static_Boolean_U_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480291, RefRangeEnd = 480293, XrefRangeStart = 480283, XrefRangeEnd = 480291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetPropagateSetTime<U>(this U playable, bool value) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetPropagateSetTime_Public_Static_Void_U_Boolean_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480301, RefRangeEnd = 480303, XrefRangeStart = 480293, XrefRangeEnd = 480301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetInputCount<U>(this U playable, int value) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetInputCount_Public_Static_Void_U_Int32_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(17)]
  [CachedScanResults(RefRangeStart = 480312, RefRangeEnd = 480329, XrefRangeStart = 480303, XrefRangeEnd = 480312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetInputCount<U>(this U playable) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetInputCount_Public_Static_Int32_U_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(20)]
  [CachedScanResults(RefRangeStart = 480338, RefRangeEnd = 480358, XrefRangeStart = 480329, XrefRangeEnd = 480338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Playable GetInput<U>(this U playable, int inputPort) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inputPort;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetInput_Public_Static_Playable_U_Int32_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Playable*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480367, RefRangeEnd = 480368, XrefRangeStart = 480358, XrefRangeEnd = 480367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetInputWeight<U>(this U playable, int inputIndex, float weight) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inputIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &weight;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetInputWeight_Public_Static_Void_U_Int32_Single_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480380, RefRangeEnd = 480381, XrefRangeStart = 480368, XrefRangeEnd = 480380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetInputWeight<U, V>(this U playable, V input, float weight)
    where U : new()
    where V : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    V& local3;
    if (!typeof (V).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<V> local4 = (object) input;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local3 = local4 is string ? (V&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (V&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
    }
    else
      local3 = ref input;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &weight;
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetInputWeight_Public_Static_Void_U_V_Single_0<U, V>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 480390, RefRangeEnd = 480404, XrefRangeStart = 480381, XrefRangeEnd = 480390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetInputWeight<U>(this U playable, int inputIndex) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inputIndex;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetInputWeight_Public_Static_Single_U_Int32_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480412, RefRangeEnd = 480413, XrefRangeStart = 480404, XrefRangeEnd = 480412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetTraversalMode<U>(this U playable, PlayableTraversalMode mode) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mode;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetTraversalMode_Public_Static_Void_U_PlayableTraversalMode_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480422, RefRangeEnd = 480424, XrefRangeStart = 480413, XrefRangeEnd = 480422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe DirectorWrapMode GetTimeWrapMode<U>(this U playable) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetTimeWrapMode_Internal_Static_DirectorWrapMode_U_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(DirectorWrapMode*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480432, RefRangeEnd = 480433, XrefRangeStart = 480424, XrefRangeEnd = 480432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetTimeWrapMode<U>(this U playable, DirectorWrapMode value) where U : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    U& local1;
    if (!typeof (U).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<U> local2 = (object) playable;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (U&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (U&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref playable;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetTimeWrapMode_Internal_Static_Void_U_DirectorWrapMode_0<U>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public PlayableExtensions(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static bool IsNull<U>(U playable) where U : struct => playable.GetHandle().IsNull();

  public static void Destroy<U>(U playable) where U : struct => playable.GetHandle().Destroy();

  public static void SetPlayState<U>(U playable, PlayState value) where U : struct
  {
    if (value == PlayState.Delayed)
      throw new Il2CppSystem.ArgumentException("Can't set Delayed: use SetDelay() instead");
    switch (value)
    {
      case PlayState.Paused:
        playable.GetHandle().Pause();
        break;
      case PlayState.Playing:
        playable.GetHandle().Play();
        break;
    }
  }

  public static double GetSpeed<U>(U playable) where U : struct => playable.GetHandle().GetSpeed();

  public static void SetDone<U>(U playable, bool value) where U : struct
  {
    playable.GetHandle().SetDone(value);
  }

  public static bool GetPropagateSetTime<U>(U playable) where U : struct
  {
    return playable.GetHandle().GetPropagateSetTime();
  }

  public static bool CanChangeInputs<U>(U playable) where U : struct
  {
    return playable.GetHandle().CanChangeInputs();
  }

  public static bool CanSetWeights<U>(U playable) where U : struct
  {
    return playable.GetHandle().CanSetWeights();
  }

  public static bool CanDestroy<U>(U playable) where U : struct
  {
    return playable.GetHandle().CanDestroy();
  }

  public static void SetOutputCount<U>(U playable, int value) where U : struct
  {
    playable.GetHandle().SetOutputCount(value);
  }

  public static int GetOutputCount<U>(U playable) where U : struct
  {
    return playable.GetHandle().GetOutputCount();
  }

  public static Playable GetOutput<U>(U playable, int outputPort) where U : struct
  {
    return playable.GetHandle().GetOutput(outputPort);
  }

  public static void ConnectInput<U, V>(
    U playable,
    int inputIndex,
    V sourcePlayable,
    int sourceOutputIndex)
    where U : struct
    where V : struct
  {
    PlayableExtensions.ConnectInput<U, V>(playable, inputIndex, sourcePlayable, sourceOutputIndex, 0.0f);
  }

  public static void ConnectInput<U, V>(
    U playable,
    int inputIndex,
    V sourcePlayable,
    int sourceOutputIndex,
    float weight)
    where U : struct
    where V : struct
  {
    playable.GetGraph<U>().Connect<V, U>(sourcePlayable, sourceOutputIndex, playable, inputIndex);
    playable.SetInputWeight<U>(inputIndex, weight);
  }

  public static void DisconnectInput<U>(U playable, int inputPort) where U : struct
  {
    playable.GetGraph<U>().Disconnect<U>(playable, inputPort);
  }

  public static int AddInput<U, V>(
    U playable,
    V sourcePlayable,
    int sourceOutputIndex,
    float weight = default (float))
    where U : struct
    where V : struct
  {
    int inputCount = playable.GetInputCount<U>();
    playable.SetInputCount<U>(inputCount + 1);
    PlayableExtensions.ConnectInput<U, V>(playable, inputCount, sourcePlayable, sourceOutputIndex, weight);
    return inputCount;
  }

  public static void SetDelay<U>(U playable, double delay) where U : struct
  {
    playable.GetHandle().SetDelay(delay);
  }

  public static double GetDelay<U>(U playable) where U : struct => playable.GetHandle().GetDelay();

  public static bool IsDelayed<U>(U playable) where U : struct => playable.GetHandle().IsDelayed();

  public static void SetLeadTime<U>(U playable, float value) where U : struct
  {
    playable.GetHandle().SetLeadTime(value);
  }

  public static float GetLeadTime<U>(U playable) where U : struct
  {
    return playable.GetHandle().GetLeadTime();
  }

  public static PlayableTraversalMode GetTraversalMode<U>(U playable) where U : struct
  {
    return playable.GetHandle().GetTraversalMode();
  }

  public static int GetOutputPortFromInputConnection<U>(U playable, int inputIndex) where U : struct
  {
    return playable.GetHandle().GetOutputPortFromInputConnection(inputIndex);
  }

  public static int GetInputPortFromOutputConnection<U>(U playable, int outputIndex) where U : struct
  {
    return playable.GetHandle().GetInputPortFromOutputConnection(outputIndex);
  }

  private sealed class MethodInfoStoreGeneric_IsValid_Public_Static_Boolean_U_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetGraph_Public_Static_PlayableGraph_U_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetGraph_Public_Static_PlayableGraph_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetPlayState_Public_Static_PlayState_U_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetPlayState_Public_Static_PlayState_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_Play_Public_Static_Void_U_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_Play_Public_Static_Void_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_Pause_Public_Static_Void_U_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_Pause_Public_Static_Void_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SetSpeed_Public_Static_Void_U_Double_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetSpeed_Public_Static_Void_U_Double_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SetDuration_Public_Static_Void_U_Double_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetDuration_Public_Static_Void_U_Double_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetDuration_Public_Static_Double_U_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetDuration_Public_Static_Double_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SetTime_Public_Static_Void_U_Double_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetTime_Public_Static_Void_U_Double_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetTime_Public_Static_Double_U_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetTime_Public_Static_Double_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetPreviousTime_Public_Static_Double_U_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetPreviousTime_Public_Static_Double_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_IsDone_Public_Static_Boolean_U_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_IsDone_Public_Static_Boolean_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SetPropagateSetTime_Public_Static_Void_U_Boolean_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetPropagateSetTime_Public_Static_Void_U_Boolean_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SetInputCount_Public_Static_Void_U_Int32_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetInputCount_Public_Static_Void_U_Int32_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetInputCount_Public_Static_Int32_U_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetInputCount_Public_Static_Int32_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetInput_Public_Static_Playable_U_Int32_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetInput_Public_Static_Playable_U_Int32_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SetInputWeight_Public_Static_Void_U_Int32_Single_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetInputWeight_Public_Static_Void_U_Int32_Single_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SetInputWeight_Public_Static_Void_U_V_Single_0<U, V>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetInputWeight_Public_Static_Void_U_V_Single_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetInputWeight_Public_Static_Single_U_Int32_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetInputWeight_Public_Static_Single_U_Int32_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SetTraversalMode_Public_Static_Void_U_PlayableTraversalMode_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetTraversalMode_Public_Static_Void_U_PlayableTraversalMode_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetTimeWrapMode_Internal_Static_DirectorWrapMode_U_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetTimeWrapMode_Internal_Static_DirectorWrapMode_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SetTimeWrapMode_Internal_Static_Void_U_DirectorWrapMode_0<U>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetTimeWrapMode_Internal_Static_Void_U_DirectorWrapMode_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }
}
