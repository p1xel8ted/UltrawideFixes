// Decompiled with JetBrains decompiler
// Type: UnityEngine.Windows.Speech.PhraseRecognizer
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Windows.Speech;

public class PhraseRecognizer(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Recognizer;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnPhraseRecognized;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokePhraseRecognizedEvent_Private_Void_IntPtr_Int32_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_Int64_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MarshalSemanticMeaning_Private_Static_Il2CppReferenceArray_1_SemanticMeaning_IntPtr_IntPtr_IntPtr_Int32_0;
  private static readonly PhraseRecognizer.CreateFromKeywordsDelegate CreateFromKeywordsDelegateField;
  private static readonly PhraseRecognizer.Start_InternalDelegate Start_InternalDelegateField;
  private static readonly PhraseRecognizer.Stop_InternalDelegate Stop_InternalDelegateField;
  private static readonly PhraseRecognizer.IsRunning_InternalDelegate IsRunning_InternalDelegateField;
  private static readonly PhraseRecognizer.DestroyDelegate DestroyDelegateField;
  private static readonly PhraseRecognizer.DestroyThreadedDelegate DestroyThreadedDelegateField;
  private static readonly PhraseRecognizer.CreateFromGrammarFile_InjectedDelegate CreateFromGrammarFile_InjectedDelegateField;

  static PhraseRecognizer()
  {
    Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", nameof (PhraseRecognizer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr);
    PhraseRecognizer.NativeFieldInfoPtr_m_Recognizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, nameof (m_Recognizer));
    PhraseRecognizer.NativeFieldInfoPtr_OnPhraseRecognized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, nameof (OnPhraseRecognized));
    PhraseRecognizer.NativeMethodInfoPtr_InvokePhraseRecognizedEvent_Private_Void_IntPtr_Int32_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, 100668967);
    PhraseRecognizer.NativeMethodInfoPtr_MarshalSemanticMeaning_Private_Static_Il2CppReferenceArray_1_SemanticMeaning_IntPtr_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, 100668968);
    PhraseRecognizer.CreateFromKeywordsDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.CreateFromKeywordsDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::CreateFromKeywords");
    PhraseRecognizer.Start_InternalDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.Start_InternalDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::Start_Internal");
    PhraseRecognizer.Stop_InternalDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.Stop_InternalDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::Stop_Internal");
    PhraseRecognizer.IsRunning_InternalDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.IsRunning_InternalDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::IsRunning_Internal");
    PhraseRecognizer.DestroyDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.DestroyDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::Destroy");
    PhraseRecognizer.DestroyThreadedDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.DestroyThreadedDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::DestroyThreaded");
    PhraseRecognizer.CreateFromGrammarFile_InjectedDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.CreateFromGrammarFile_InjectedDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::CreateFromGrammarFile_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472730, XrefRangeEnd = 472740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InvokePhraseRecognizedEvent(
    System.IntPtr rawText,
    int rawTextLength,
    ConfidenceLevel confidence,
    Il2CppReferenceArray<SemanticMeaning> semanticMeanings,
    long phraseStartFileTime,
    long phraseDurationTicks)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &rawText;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rawTextLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &confidence;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) semanticMeanings);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &phraseStartFileTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &phraseDurationTicks;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhraseRecognizer.NativeMethodInfoPtr_InvokePhraseRecognizedEvent_Private_Void_IntPtr_Int32_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472740, XrefRangeEnd = 472752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppReferenceArray<SemanticMeaning> MarshalSemanticMeaning(
    System.IntPtr keys,
    System.IntPtr values,
    System.IntPtr valueSizes,
    int valueCount)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &keys;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &values;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &valueSizes;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &valueCount;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PhraseRecognizer.NativeMethodInfoPtr_MarshalSemanticMeaning_Private_Static_Il2CppReferenceArray_1_SemanticMeaning_IntPtr_IntPtr_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<SemanticMeaning>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<SemanticMeaning>>(num3);
  }

  public unsafe System.IntPtr m_Recognizer
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhraseRecognizer.NativeFieldInfoPtr_m_Recognizer));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhraseRecognizer.NativeFieldInfoPtr_m_Recognizer)) = value;
    }
  }

  public unsafe PhraseRecognizer.PhraseRecognizedDelegate OnPhraseRecognized
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhraseRecognizer.NativeFieldInfoPtr_OnPhraseRecognized));
      return num == System.IntPtr.Zero ? (PhraseRecognizer.PhraseRecognizedDelegate) null : Il2CppObjectPool.Get<PhraseRecognizer.PhraseRecognizedDelegate>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PhraseRecognizer.NativeFieldInfoPtr_OnPhraseRecognized), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static System.IntPtr CreateFromKeywords(
    Il2CppSystem.Object self,
    Il2CppStringArray keywords,
    ConfidenceLevel minimumConfidence)
  {
    return PhraseRecognizer.CreateFromKeywordsDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) self), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keywords), minimumConfidence);
  }

  public static unsafe System.IntPtr CreateFromGrammarFile(
    Il2CppSystem.Object self,
    string grammarFilePath,
    ConfidenceLevel minimumConfidence)
  {
    try
    {
      Il2CppSystem.Object self1 = self;
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(grammarFilePath, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = grammarFilePath.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      int minimumConfidence1 = (int) minimumConfidence;
      return PhraseRecognizer.CreateFromGrammarFile_Injected(self1, ref local, (ConfidenceLevel) minimumConfidence1);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static void Start_Internal(System.IntPtr recognizer)
  {
    PhraseRecognizer.Start_InternalDelegateField(recognizer);
  }

  public static void Stop_Internal(System.IntPtr recognizer)
  {
    PhraseRecognizer.Stop_InternalDelegateField(recognizer);
  }

  public static bool IsRunning_Internal(System.IntPtr recognizer)
  {
    return PhraseRecognizer.IsRunning_InternalDelegateField(recognizer);
  }

  public static void Destroy(System.IntPtr recognizer)
  {
    PhraseRecognizer.DestroyDelegateField(recognizer);
  }

  public static void DestroyThreaded(System.IntPtr recognizer)
  {
    PhraseRecognizer.DestroyThreadedDelegateField(recognizer);
  }

  [SpecialName]
  public void add_OnPhraseRecognized(PhraseRecognizer.PhraseRecognizedDelegate value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public void remove_OnPhraseRecognized(PhraseRecognizer.PhraseRecognizedDelegate value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public new virtual void Finalize()
  {
    try
    {
      if (!(this.m_Recognizer != Il2CppSystem.IntPtr.Zero))
        return;
      PhraseRecognizer.DestroyThreaded(this.m_Recognizer);
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
    PhraseRecognizer.Start_Internal(this.m_Recognizer);
  }

  public void Stop()
  {
    if (this.m_Recognizer == Il2CppSystem.IntPtr.Zero)
      return;
    PhraseRecognizer.Stop_Internal(this.m_Recognizer);
  }

  public void Dispose()
  {
    if (this.m_Recognizer != Il2CppSystem.IntPtr.Zero)
    {
      PhraseRecognizer.Destroy(this.m_Recognizer);
      this.m_Recognizer = Il2CppSystem.IntPtr.Zero;
    }
    Il2CppSystem.GC.SuppressFinalize((Il2CppSystem.Object) this);
  }

  public bool IsRunning
  {
    get
    {
      return this.m_Recognizer != Il2CppSystem.IntPtr.Zero && PhraseRecognizer.IsRunning_Internal(this.m_Recognizer);
    }
  }

  public static System.IntPtr CreateFromGrammarFile_Injected(
    Il2CppSystem.Object self,
    ref ManagedSpanWrapper grammarFilePath,
    ConfidenceLevel minimumConfidence)
  {
    return PhraseRecognizer.CreateFromGrammarFile_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) self), (System.IntPtr) ref grammarFilePath, minimumConfidence);
  }

  public sealed class PhraseRecognizedDelegate(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhraseRecognizedEventArgs_0;

    static PhraseRecognizedDelegate()
    {
      Il2CppClassPointerStore<PhraseRecognizer.PhraseRecognizedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, nameof (PhraseRecognizedDelegate));
      PhraseRecognizer.PhraseRecognizedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizer.PhraseRecognizedDelegate>.NativeClassPtr, 100668969);
      PhraseRecognizer.PhraseRecognizedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhraseRecognizedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizer.PhraseRecognizedDelegate>.NativeClassPtr, 100668970);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 472729, RefRangeEnd = 472730, XrefRangeStart = 472727, XrefRangeEnd = 472729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhraseRecognizedDelegate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognizer.PhraseRecognizedDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PhraseRecognizer.PhraseRecognizedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(PhraseRecognizedEventArgs args)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) args))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PhraseRecognizer.PhraseRecognizedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhraseRecognizedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator PhraseRecognizer.PhraseRecognizedDelegate(
      [In] System.Action<PhraseRecognizedEventArgs> obj0)
    {
      return DelegateSupport.ConvertDelegate<PhraseRecognizer.PhraseRecognizedDelegate>((System.Delegate) obj0);
    }

    public static PhraseRecognizer.PhraseRecognizedDelegate operator +(
      [In] PhraseRecognizer.PhraseRecognizedDelegate obj0,
      [In] PhraseRecognizer.PhraseRecognizedDelegate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<PhraseRecognizer.PhraseRecognizedDelegate>();
    }

    public static PhraseRecognizer.PhraseRecognizedDelegate operator -(
      [In] PhraseRecognizer.PhraseRecognizedDelegate obj0,
      [In] PhraseRecognizer.PhraseRecognizedDelegate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (PhraseRecognizer.PhraseRecognizedDelegate) @delegate : @delegate.Cast<PhraseRecognizer.PhraseRecognizedDelegate>();
    }
  }

  private delegate System.IntPtr CreateFromKeywordsDelegate(
    System.IntPtr self,
    System.IntPtr keywords,
    ConfidenceLevel minimumConfidence);

  private delegate void Start_InternalDelegate(System.IntPtr recognizer);

  private delegate void Stop_InternalDelegate(System.IntPtr recognizer);

  private delegate bool IsRunning_InternalDelegate(System.IntPtr recognizer);

  private delegate void DestroyDelegate(System.IntPtr recognizer);

  private delegate void DestroyThreadedDelegate(System.IntPtr recognizer);

  private delegate System.IntPtr CreateFromGrammarFile_InjectedDelegate(
    System.IntPtr self,
    System.IntPtr grammarFilePath,
    ConfidenceLevel minimumConfidence);
}
