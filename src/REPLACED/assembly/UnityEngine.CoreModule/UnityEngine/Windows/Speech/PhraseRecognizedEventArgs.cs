// Decompiled with JetBrains decompiler
// Type: UnityEngine.Windows.Speech.PhraseRecognizedEventArgs
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Windows.Speech;

public sealed class PhraseRecognizedEventArgs : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_confidence;
  private static readonly System.IntPtr NativeFieldInfoPtr_semanticMeanings;
  private static readonly System.IntPtr NativeFieldInfoPtr_text;
  private static readonly System.IntPtr NativeFieldInfoPtr_phraseStartTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_phraseDuration;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_DateTime_TimeSpan_0;

  static PhraseRecognizedEventArgs()
  {
    Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", nameof (PhraseRecognizedEventArgs));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr);
    PhraseRecognizedEventArgs.NativeFieldInfoPtr_confidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, nameof (confidence));
    PhraseRecognizedEventArgs.NativeFieldInfoPtr_semanticMeanings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, nameof (semanticMeanings));
    PhraseRecognizedEventArgs.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, nameof (text));
    PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, nameof (phraseStartTime));
    PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, nameof (phraseDuration));
    PhraseRecognizedEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, 100668983);
  }

  [CallerCount(0)]
  public unsafe PhraseRecognizedEventArgs(
    string text,
    ConfidenceLevel confidence,
    Il2CppReferenceArray<SemanticMeaning> semanticMeanings,
    Il2CppSystem.DateTime phraseStartTime,
    Il2CppSystem.TimeSpan phraseDuration)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &confidence;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) semanticMeanings);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &phraseStartTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &phraseDuration;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhraseRecognizedEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_DateTime_TimeSpan_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public PhraseRecognizedEventArgs(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public PhraseRecognizedEventArgs()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr))
  {
  }

  public unsafe ConfidenceLevel confidence
  {
    get
    {
      return *(ConfidenceLevel*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_confidence));
    }
    [param: In] set
    {
      *(ConfidenceLevel*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_confidence)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<SemanticMeaning> semanticMeanings
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_semanticMeanings));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<SemanticMeaning>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<SemanticMeaning>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_semanticMeanings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string text
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_text)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppSystem.DateTime phraseStartTime
  {
    get
    {
      return *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseStartTime));
    }
    [param: In] set
    {
      *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseStartTime)) = value;
    }
  }

  public unsafe Il2CppSystem.TimeSpan phraseDuration
  {
    get
    {
      return *(Il2CppSystem.TimeSpan*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseDuration));
    }
    [param: In] set
    {
      *(Il2CppSystem.TimeSpan*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseDuration)) = value;
    }
  }
}
