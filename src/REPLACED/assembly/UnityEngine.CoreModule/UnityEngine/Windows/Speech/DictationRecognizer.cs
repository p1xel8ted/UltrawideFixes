// Decompiled with JetBrains decompiler
// Type: UnityEngine.Windows.Speech.DictationRecognizer
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Windows.Speech;

public sealed class DictationRecognizer(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Recognizer;
  private static readonly System.IntPtr NativeFieldInfoPtr_DictationHypothesis;
  private static readonly System.IntPtr NativeFieldInfoPtr_DictationResult;
  private static readonly System.IntPtr NativeFieldInfoPtr_DictationComplete;
  private static readonly System.IntPtr NativeFieldInfoPtr_DictationError;
  private static readonly System.IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeHypothesisGeneratedEvent_Private_Void_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeResultGeneratedEvent_Private_Void_IntPtr_Int32_ConfidenceLevel_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeCompletedEvent_Private_Void_DictationCompletionCause_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeErrorEvent_Private_Void_String_Int32_0;
  private static readonly DictationRecognizer.CreateDelegate CreateDelegateField;
  private static readonly DictationRecognizer.StartDelegate StartDelegateField;
  private static readonly DictationRecognizer.StopDelegate StopDelegateField;
  private static readonly DictationRecognizer.DestroyDelegate DestroyDelegateField;
  private static readonly DictationRecognizer.DestroyThreadedDelegate DestroyThreadedDelegateField;
  private static readonly DictationRecognizer.GetStatusDelegate GetStatusDelegateField;
  private static readonly DictationRecognizer.GetAutoSilenceTimeoutSecondsDelegate GetAutoSilenceTimeoutSecondsDelegateField;
  private static readonly DictationRecognizer.SetAutoSilenceTimeoutSecondsDelegate SetAutoSilenceTimeoutSecondsDelegateField;
  private static readonly DictationRecognizer.GetInitialSilenceTimeoutSecondsDelegate GetInitialSilenceTimeoutSecondsDelegateField;
  private static readonly DictationRecognizer.SetInitialSilenceTimeoutSecondsDelegate SetInitialSilenceTimeoutSecondsDelegateField;

  static DictationRecognizer()
  {
    Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", nameof (DictationRecognizer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr);
    DictationRecognizer.NativeFieldInfoPtr_m_Recognizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, nameof (m_Recognizer));
    DictationRecognizer.NativeFieldInfoPtr_DictationHypothesis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, nameof (DictationHypothesis));
    DictationRecognizer.NativeFieldInfoPtr_DictationResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, nameof (DictationResult));
    DictationRecognizer.NativeFieldInfoPtr_DictationComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, nameof (DictationComplete));
    DictationRecognizer.NativeFieldInfoPtr_DictationError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, nameof (DictationError));
    DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeHypothesisGeneratedEvent_Private_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100668971);
    DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeResultGeneratedEvent_Private_Void_IntPtr_Int32_ConfidenceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100668972);
    DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeCompletedEvent_Private_Void_DictationCompletionCause_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100668973);
    DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeErrorEvent_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100668974);
    DictationRecognizer.CreateDelegateField = IL2CPP.ResolveICall<DictationRecognizer.CreateDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::Create");
    DictationRecognizer.StartDelegateField = IL2CPP.ResolveICall<DictationRecognizer.StartDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::Start");
    DictationRecognizer.StopDelegateField = IL2CPP.ResolveICall<DictationRecognizer.StopDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::Stop");
    DictationRecognizer.DestroyDelegateField = IL2CPP.ResolveICall<DictationRecognizer.DestroyDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::Destroy");
    DictationRecognizer.DestroyThreadedDelegateField = IL2CPP.ResolveICall<DictationRecognizer.DestroyThreadedDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::DestroyThreaded");
    DictationRecognizer.GetStatusDelegateField = IL2CPP.ResolveICall<DictationRecognizer.GetStatusDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::GetStatus");
    DictationRecognizer.GetAutoSilenceTimeoutSecondsDelegateField = IL2CPP.ResolveICall<DictationRecognizer.GetAutoSilenceTimeoutSecondsDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::GetAutoSilenceTimeoutSeconds");
    DictationRecognizer.SetAutoSilenceTimeoutSecondsDelegateField = IL2CPP.ResolveICall<DictationRecognizer.SetAutoSilenceTimeoutSecondsDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::SetAutoSilenceTimeoutSeconds");
    DictationRecognizer.GetInitialSilenceTimeoutSecondsDelegateField = IL2CPP.ResolveICall<DictationRecognizer.GetInitialSilenceTimeoutSecondsDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::GetInitialSilenceTimeoutSeconds");
    DictationRecognizer.SetInitialSilenceTimeoutSecondsDelegateField = IL2CPP.ResolveICall<DictationRecognizer.SetInitialSilenceTimeoutSecondsDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::SetInitialSilenceTimeoutSeconds");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472755, XrefRangeEnd = 472757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DictationRecognizer_InvokeHypothesisGeneratedEvent(
    System.IntPtr keyword,
    int keywordLength)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &keyword;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &keywordLength;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeHypothesisGeneratedEvent_Private_Void_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472757, XrefRangeEnd = 472759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DictationRecognizer_InvokeResultGeneratedEvent(
    System.IntPtr keyword,
    int keywordLength,
    ConfidenceLevel minimumConfidence)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &keyword;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &keywordLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &minimumConfidence;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeResultGeneratedEvent_Private_Void_IntPtr_Int32_ConfidenceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &cause
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeCompletedEvent_Private_Void_DictationCompletionCause_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void DictationRecognizer_InvokeErrorEvent(string error, int hresult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(error);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hresult;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeErrorEvent_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr m_Recognizer
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_m_Recognizer));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_m_Recognizer)) = value;
    }
  }

  public unsafe DictationRecognizer.DictationHypothesisDelegate DictationHypothesis
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationHypothesis));
      return num == System.IntPtr.Zero ? (DictationRecognizer.DictationHypothesisDelegate) null : Il2CppObjectPool.Get<DictationRecognizer.DictationHypothesisDelegate>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationHypothesis), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DictationRecognizer.DictationResultDelegate DictationResult
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationResult));
      return num == System.IntPtr.Zero ? (DictationRecognizer.DictationResultDelegate) null : Il2CppObjectPool.Get<DictationRecognizer.DictationResultDelegate>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationResult), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DictationRecognizer.DictationCompletedDelegate DictationComplete
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationComplete));
      return num == System.IntPtr.Zero ? (DictationRecognizer.DictationCompletedDelegate) null : Il2CppObjectPool.Get<DictationRecognizer.DictationCompletedDelegate>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationComplete), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DictationRecognizer.DictationErrorHandler DictationError
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationError));
      return num == System.IntPtr.Zero ? (DictationRecognizer.DictationErrorHandler) null : Il2CppObjectPool.Get<DictationRecognizer.DictationErrorHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationError), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static System.IntPtr Create(
    Il2CppSystem.Object self,
    ConfidenceLevel minimumConfidence,
    DictationTopicConstraint topicConstraint)
  {
    return DictationRecognizer.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) self), minimumConfidence, topicConstraint);
  }

  public static void Start(System.IntPtr self) => DictationRecognizer.StartDelegateField(self);

  public static void Stop(System.IntPtr self) => DictationRecognizer.StopDelegateField(self);

  public static void Destroy(System.IntPtr self) => DictationRecognizer.DestroyDelegateField(self);

  public static void DestroyThreaded(System.IntPtr self)
  {
    DictationRecognizer.DestroyThreadedDelegateField(self);
  }

  public static SpeechSystemStatus GetStatus(System.IntPtr self)
  {
    return DictationRecognizer.GetStatusDelegateField(self);
  }

  public static float GetAutoSilenceTimeoutSeconds(System.IntPtr self)
  {
    return DictationRecognizer.GetAutoSilenceTimeoutSecondsDelegateField(self);
  }

  public static void SetAutoSilenceTimeoutSeconds(System.IntPtr self, float value)
  {
    DictationRecognizer.SetAutoSilenceTimeoutSecondsDelegateField(self, value);
  }

  public static float GetInitialSilenceTimeoutSeconds(System.IntPtr self)
  {
    return DictationRecognizer.GetInitialSilenceTimeoutSecondsDelegateField(self);
  }

  public static void SetInitialSilenceTimeoutSeconds(System.IntPtr self, float value)
  {
    DictationRecognizer.SetInitialSilenceTimeoutSecondsDelegateField(self, value);
  }

  [SpecialName]
  public void add_DictationHypothesis(
    DictationRecognizer.DictationHypothesisDelegate value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public void remove_DictationHypothesis(
    DictationRecognizer.DictationHypothesisDelegate value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public void add_DictationResult(DictationRecognizer.DictationResultDelegate value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public void remove_DictationResult(DictationRecognizer.DictationResultDelegate value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public void add_DictationComplete(
    DictationRecognizer.DictationCompletedDelegate value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public void remove_DictationComplete(
    DictationRecognizer.DictationCompletedDelegate value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public void add_DictationError(DictationRecognizer.DictationErrorHandler value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public void remove_DictationError(DictationRecognizer.DictationErrorHandler value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public SpeechSystemStatus Status
  {
    get
    {
      return this.m_Recognizer != Il2CppSystem.IntPtr.Zero ? DictationRecognizer.GetStatus(this.m_Recognizer) : SpeechSystemStatus.Stopped;
    }
  }

  public float AutoSilenceTimeoutSeconds
  {
    get
    {
      return this.m_Recognizer == Il2CppSystem.IntPtr.Zero ? 0.0f : DictationRecognizer.GetAutoSilenceTimeoutSeconds(this.m_Recognizer);
    }
    set
    {
      if (this.m_Recognizer == Il2CppSystem.IntPtr.Zero)
        return;
      DictationRecognizer.SetAutoSilenceTimeoutSeconds(this.m_Recognizer, value);
    }
  }

  public float InitialSilenceTimeoutSeconds
  {
    get
    {
      return this.m_Recognizer == Il2CppSystem.IntPtr.Zero ? 0.0f : DictationRecognizer.GetInitialSilenceTimeoutSeconds(this.m_Recognizer);
    }
    set
    {
      if (this.m_Recognizer == Il2CppSystem.IntPtr.Zero)
        return;
      DictationRecognizer.SetInitialSilenceTimeoutSeconds(this.m_Recognizer, value);
    }
  }

  public new virtual void Finalize()
  {
    try
    {
      if (!(this.m_Recognizer != Il2CppSystem.IntPtr.Zero))
        return;
      DictationRecognizer.DestroyThreaded(this.m_Recognizer);
      this.m_Recognizer = Il2CppSystem.IntPtr.Zero;
      Il2CppSystem.GC.SuppressFinalize((Il2CppSystem.Object) this);
    }
    finally
    {
      base.Finalize();
    }
  }

  public void Start()
  {
    if (this.m_Recognizer == Il2CppSystem.IntPtr.Zero)
      return;
    DictationRecognizer.Start(this.m_Recognizer);
  }

  public void Stop()
  {
    if (this.m_Recognizer == Il2CppSystem.IntPtr.Zero)
      return;
    DictationRecognizer.Stop(this.m_Recognizer);
  }

  public void Dispose()
  {
    if (this.m_Recognizer != Il2CppSystem.IntPtr.Zero)
    {
      DictationRecognizer.Destroy(this.m_Recognizer);
      this.m_Recognizer = Il2CppSystem.IntPtr.Zero;
    }
    Il2CppSystem.GC.SuppressFinalize((Il2CppSystem.Object) this);
  }

  public sealed class DictationHypothesisDelegate(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;

    static DictationHypothesisDelegate()
    {
      Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, nameof (DictationHypothesisDelegate));
      DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr, 100668975);
      DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr, 100668976);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 416874, RefRangeEnd = 416875, XrefRangeStart = 416874, XrefRangeEnd = 416875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DictationHypothesisDelegate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(text)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator DictationRecognizer.DictationHypothesisDelegate(
      [In] System.Action<string> obj0)
    {
      return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationHypothesisDelegate>((System.Delegate) obj0);
    }

    public static DictationRecognizer.DictationHypothesisDelegate operator +(
      [In] DictationRecognizer.DictationHypothesisDelegate obj0,
      [In] DictationRecognizer.DictationHypothesisDelegate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<DictationRecognizer.DictationHypothesisDelegate>();
    }

    public static DictationRecognizer.DictationHypothesisDelegate operator -(
      [In] DictationRecognizer.DictationHypothesisDelegate obj0,
      [In] DictationRecognizer.DictationHypothesisDelegate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (DictationRecognizer.DictationHypothesisDelegate) @delegate : @delegate.Cast<DictationRecognizer.DictationHypothesisDelegate>();
    }
  }

  public sealed class DictationResultDelegate(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ConfidenceLevel_0;

    static DictationResultDelegate()
    {
      Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, nameof (DictationResultDelegate));
      DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr, 100668977);
      DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ConfidenceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr, 100668978);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472752, XrefRangeEnd = 472755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DictationResultDelegate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(string text, ConfidenceLevel confidence)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &confidence;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ConfidenceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator DictationRecognizer.DictationResultDelegate(
      [In] System.Action<string, ConfidenceLevel> obj0)
    {
      return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationResultDelegate>((System.Delegate) obj0);
    }

    public static DictationRecognizer.DictationResultDelegate operator +(
      [In] DictationRecognizer.DictationResultDelegate obj0,
      [In] DictationRecognizer.DictationResultDelegate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<DictationRecognizer.DictationResultDelegate>();
    }

    public static DictationRecognizer.DictationResultDelegate operator -(
      [In] DictationRecognizer.DictationResultDelegate obj0,
      [In] DictationRecognizer.DictationResultDelegate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (DictationRecognizer.DictationResultDelegate) @delegate : @delegate.Cast<DictationRecognizer.DictationResultDelegate>();
    }
  }

  public sealed class DictationCompletedDelegate(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DictationCompletionCause_0;

    static DictationCompletedDelegate()
    {
      Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, nameof (DictationCompletedDelegate));
      DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr, 100668979);
      DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DictationCompletionCause_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr, 100668980);
    }

    [CallerCount(120)]
    [CachedScanResults(RefRangeStart = 472603, RefRangeEnd = 472723, XrefRangeStart = 472603, XrefRangeEnd = 472723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DictationCompletedDelegate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(DictationCompletionCause cause)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &cause
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DictationCompletionCause_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator DictationRecognizer.DictationCompletedDelegate(
      [In] System.Action<DictationCompletionCause> obj0)
    {
      return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationCompletedDelegate>((System.Delegate) obj0);
    }

    public static DictationRecognizer.DictationCompletedDelegate operator +(
      [In] DictationRecognizer.DictationCompletedDelegate obj0,
      [In] DictationRecognizer.DictationCompletedDelegate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<DictationRecognizer.DictationCompletedDelegate>();
    }

    public static DictationRecognizer.DictationCompletedDelegate operator -(
      [In] DictationRecognizer.DictationCompletedDelegate obj0,
      [In] DictationRecognizer.DictationCompletedDelegate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (DictationRecognizer.DictationCompletedDelegate) @delegate : @delegate.Cast<DictationRecognizer.DictationCompletedDelegate>();
    }
  }

  public sealed class DictationErrorHandler(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_0;

    static DictationErrorHandler()
    {
      Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, nameof (DictationErrorHandler));
      DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr, 100668981);
      DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr, 100668982);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DictationErrorHandler(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(string error, int hresult)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(error);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hresult;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator DictationRecognizer.DictationErrorHandler(
      [In] System.Action<string, int> obj0)
    {
      return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationErrorHandler>((System.Delegate) obj0);
    }

    public static DictationRecognizer.DictationErrorHandler operator +(
      [In] DictationRecognizer.DictationErrorHandler obj0,
      [In] DictationRecognizer.DictationErrorHandler obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<DictationRecognizer.DictationErrorHandler>();
    }

    public static DictationRecognizer.DictationErrorHandler operator -(
      [In] DictationRecognizer.DictationErrorHandler obj0,
      [In] DictationRecognizer.DictationErrorHandler obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (DictationRecognizer.DictationErrorHandler) @delegate : @delegate.Cast<DictationRecognizer.DictationErrorHandler>();
    }
  }

  private delegate System.IntPtr CreateDelegate(
    System.IntPtr self,
    ConfidenceLevel minimumConfidence,
    DictationTopicConstraint topicConstraint);

  private delegate void StartDelegate(System.IntPtr self);

  private delegate void StopDelegate(System.IntPtr self);

  private delegate void DestroyDelegate(System.IntPtr self);

  private delegate void DestroyThreadedDelegate(System.IntPtr self);

  private delegate SpeechSystemStatus GetStatusDelegate(System.IntPtr self);

  private delegate float GetAutoSilenceTimeoutSecondsDelegate(System.IntPtr self);

  private delegate void SetAutoSilenceTimeoutSecondsDelegate(System.IntPtr self, float value);

  private delegate float GetInitialSilenceTimeoutSecondsDelegate(System.IntPtr self);

  private delegate void SetInitialSilenceTimeoutSecondsDelegate(System.IntPtr self, float value);
}
