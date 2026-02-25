// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.SubtitlesManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using SadCatStudios.Foundation.Events;
using SadCatStudios.UI.Elements;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.Dialogs;

public class SubtitlesManager(System.IntPtr pointer) : LocalSingletonBehaviour<SubtitlesManager>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_subtitlesTypewriter;
  private static readonly System.IntPtr NativeFieldInfoPtr_speakerMarker;
  private static readonly System.IntPtr NativeFieldInfoPtr_continueTextLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_canvasGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_stringBuilder;
  private static readonly System.IntPtr NativeFieldInfoPtr_continueAutoskipSlider;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastSpeechMarker;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventDisposable;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LastLine_Public_get_ArticyRef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitLine_Public_Void_ArticyRef_SpeechController_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoTextInitialization_Private_Void_ArticyRef_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnLanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseLine_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetVisibility_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTime_Public_Boolean_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FullyPrinted_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LastCharTime_Public_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentLineDuration_Public_get_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetContinueLabelEnabled_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupContinueAutoskip_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetContinueAutoskipTime_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnResetToCheckpoint_Private_Void_ResetToCheckpointEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SubtitlesManager()
  {
    Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs", nameof (SubtitlesManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr);
    SubtitlesManager.NativeFieldInfoPtr_subtitlesTypewriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, nameof (subtitlesTypewriter));
    SubtitlesManager.NativeFieldInfoPtr_speakerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, nameof (speakerMarker));
    SubtitlesManager.NativeFieldInfoPtr_continueTextLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, nameof (continueTextLabel));
    SubtitlesManager.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, nameof (canvasGroup));
    SubtitlesManager.NativeFieldInfoPtr_stringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, nameof (stringBuilder));
    SubtitlesManager.NativeFieldInfoPtr_continueAutoskipSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, nameof (continueAutoskipSlider));
    SubtitlesManager.NativeFieldInfoPtr_lastRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, nameof (lastRef));
    SubtitlesManager.NativeFieldInfoPtr_lastSpeechMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, nameof (lastSpeechMarker));
    SubtitlesManager.NativeFieldInfoPtr_eventDisposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, nameof (eventDisposable));
    SubtitlesManager.NativeMethodInfoPtr_get_LastLine_Public_get_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, 100672658);
    SubtitlesManager.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, 100672659);
    SubtitlesManager.NativeMethodInfoPtr_InitLine_Public_Void_ArticyRef_SpeechController_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, 100672660);
    SubtitlesManager.NativeMethodInfoPtr_DoTextInitialization_Private_Void_ArticyRef_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, 100672661);
    SubtitlesManager.NativeMethodInfoPtr_OnLanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, 100672662);
    SubtitlesManager.NativeMethodInfoPtr_ReleaseLine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, 100672663);
    SubtitlesManager.NativeMethodInfoPtr_ResetVisibility_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, 100672664);
    SubtitlesManager.NativeMethodInfoPtr_ProcessTime_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, 100672665);
    SubtitlesManager.NativeMethodInfoPtr_FullyPrinted_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, 100672666);
    SubtitlesManager.NativeMethodInfoPtr_LastCharTime_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, 100672667);
    SubtitlesManager.NativeMethodInfoPtr_get_CurrentLineDuration_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, 100672668);
    SubtitlesManager.NativeMethodInfoPtr_SetContinueLabelEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, 100672669);
    SubtitlesManager.NativeMethodInfoPtr_SetupContinueAutoskip_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, 100672670);
    SubtitlesManager.NativeMethodInfoPtr_SetContinueAutoskipTime_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, 100672671);
    SubtitlesManager.NativeMethodInfoPtr_OnResetToCheckpoint_Private_Void_ResetToCheckpointEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, 100672672);
    SubtitlesManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, 100672673);
    SubtitlesManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr, 100672674);
  }

  public unsafe ArticyRef LastLine
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SubtitlesManager.NativeMethodInfoPtr_get_LastLine_Public_get_ArticyRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102565, XrefRangeEnd = 102590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoAwake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SubtitlesManager.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 102621, RefRangeEnd = 102625, XrefRangeStart = 102590, XrefRangeEnd = 102621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitLine(
    ArticyRef articyRef,
    SpeechController speechController,
    bool showMarker = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) articyRef);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) speechController);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &showMarker;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SubtitlesManager.NativeMethodInfoPtr_InitLine_Public_Void_ArticyRef_SpeechController_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 102660, RefRangeEnd = 102662, XrefRangeStart = 102625, XrefRangeEnd = 102660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DoTextInitialization(ArticyRef articyRef, bool resetVisibility = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) articyRef);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &resetVisibility;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SubtitlesManager.NativeMethodInfoPtr_DoTextInitialization_Private_Void_ArticyRef_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102662, XrefRangeEnd = 102663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnLanguageChanged(ArticyLanguage old, ArticyLanguage newL)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) old);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newL);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SubtitlesManager.NativeMethodInfoPtr_OnLanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 102685, RefRangeEnd = 102693, XrefRangeStart = 102663, XrefRangeEnd = 102685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ReleaseLine()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SubtitlesManager.NativeMethodInfoPtr_ReleaseLine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 102695, RefRangeEnd = 102696, XrefRangeStart = 102693, XrefRangeEnd = 102695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetVisibility()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SubtitlesManager.NativeMethodInfoPtr_ResetVisibility_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 101563, RefRangeEnd = 101566, XrefRangeStart = 101563, XrefRangeEnd = 101566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ProcessTime(float time)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &time
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SubtitlesManager.NativeMethodInfoPtr_ProcessTime_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 102696, RefRangeEnd = 102697, XrefRangeStart = 102696, XrefRangeEnd = 102696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool FullyPrinted()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SubtitlesManager.NativeMethodInfoPtr_FullyPrinted_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 101560, RefRangeEnd = 101561, XrefRangeStart = 101560, XrefRangeEnd = 101561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float LastCharTime()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SubtitlesManager.NativeMethodInfoPtr_LastCharTime_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe double CurrentLineDuration
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 102697, RefRangeEnd = 102698, XrefRangeStart = 102697, XrefRangeEnd = 102697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SubtitlesManager.NativeMethodInfoPtr_get_CurrentLineDuration_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 102700, RefRangeEnd = 102702, XrefRangeStart = 102698, XrefRangeEnd = 102700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetContinueLabelEnabled(bool enabled)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &enabled
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SubtitlesManager.NativeMethodInfoPtr_SetContinueLabelEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 102709, RefRangeEnd = 102713, XrefRangeStart = 102702, XrefRangeEnd = 102709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupContinueAutoskip(float fullTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &fullTime
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SubtitlesManager.NativeMethodInfoPtr_SetupContinueAutoskip_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 102714, RefRangeEnd = 102716, XrefRangeStart = 102713, XrefRangeEnd = 102714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetContinueAutoskipTime(float time)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &time
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SubtitlesManager.NativeMethodInfoPtr_SetContinueAutoskipTime_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102716, XrefRangeEnd = 102717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnResetToCheckpoint(ResetToCheckpointEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SubtitlesManager.NativeMethodInfoPtr_OnResetToCheckpoint_Private_Void_ResetToCheckpointEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102717, XrefRangeEnd = 102732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SubtitlesManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102732, XrefRangeEnd = 102739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SubtitlesManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubtitlesManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SubtitlesManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe UITextTypeWriter subtitlesTypewriter
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubtitlesManager.NativeFieldInfoPtr_subtitlesTypewriter));
      return num == System.IntPtr.Zero ? (UITextTypeWriter) null : Il2CppObjectPool.Get<UITextTypeWriter>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SubtitlesManager.NativeFieldInfoPtr_subtitlesTypewriter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIPromtFollow speakerMarker
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubtitlesManager.NativeFieldInfoPtr_speakerMarker));
      return num == System.IntPtr.Zero ? (UIPromtFollow) null : Il2CppObjectPool.Get<UIPromtFollow>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SubtitlesManager.NativeFieldInfoPtr_speakerMarker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject continueTextLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubtitlesManager.NativeFieldInfoPtr_continueTextLabel));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SubtitlesManager.NativeFieldInfoPtr_continueTextLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CanvasGroup canvasGroup
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubtitlesManager.NativeFieldInfoPtr_canvasGroup));
      return num == System.IntPtr.Zero ? (CanvasGroup) null : Il2CppObjectPool.Get<CanvasGroup>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SubtitlesManager.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StringBuilder stringBuilder
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubtitlesManager.NativeFieldInfoPtr_stringBuilder));
      return num == System.IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SubtitlesManager.NativeFieldInfoPtr_stringBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider continueAutoskipSlider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubtitlesManager.NativeFieldInfoPtr_continueAutoskipSlider));
      return num == System.IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SubtitlesManager.NativeFieldInfoPtr_continueAutoskipSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef lastRef
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubtitlesManager.NativeFieldInfoPtr_lastRef));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SubtitlesManager.NativeFieldInfoPtr_lastRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject lastSpeechMarker
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubtitlesManager.NativeFieldInfoPtr_lastSpeechMarker));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SubtitlesManager.NativeFieldInfoPtr_lastSpeechMarker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.IDisposable eventDisposable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubtitlesManager.NativeFieldInfoPtr_eventDisposable));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SubtitlesManager.NativeFieldInfoPtr_eventDisposable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
