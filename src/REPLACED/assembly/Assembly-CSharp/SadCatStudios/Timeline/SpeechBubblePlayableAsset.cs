// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.SpeechBubblePlayableAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace SadCatStudios.Timeline;

public class SpeechBubblePlayableAsset(IntPtr pointer) : PlayableAsset(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_template;
  private static readonly IntPtr NativeFieldInfoPtr_textDuration;
  private static readonly IntPtr NativeFieldInfoPtr_text;
  private static readonly IntPtr NativeFieldInfoPtr_DelayBetweenChars;
  private static readonly IntPtr NativeFieldInfoPtr_DelayAfterPunctuatoin;
  private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_TextDuration_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SpeechBubblePlayableAsset()
  {
    Il2CppClassPointerStore<SpeechBubblePlayableAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (SpeechBubblePlayableAsset));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeechBubblePlayableAsset>.NativeClassPtr);
    SpeechBubblePlayableAsset.NativeFieldInfoPtr_template = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubblePlayableAsset>.NativeClassPtr, nameof (template));
    SpeechBubblePlayableAsset.NativeFieldInfoPtr_textDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubblePlayableAsset>.NativeClassPtr, nameof (textDuration));
    SpeechBubblePlayableAsset.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubblePlayableAsset>.NativeClassPtr, nameof (text));
    SpeechBubblePlayableAsset.NativeFieldInfoPtr_DelayBetweenChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubblePlayableAsset>.NativeClassPtr, nameof (DelayBetweenChars));
    SpeechBubblePlayableAsset.NativeFieldInfoPtr_DelayAfterPunctuatoin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubblePlayableAsset>.NativeClassPtr, nameof (DelayAfterPunctuatoin));
    SpeechBubblePlayableAsset.NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubblePlayableAsset>.NativeClassPtr, 100670796);
    SpeechBubblePlayableAsset.NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubblePlayableAsset>.NativeClassPtr, 100670797);
    SpeechBubblePlayableAsset.NativeMethodInfoPtr_get_TextDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubblePlayableAsset>.NativeClassPtr, 100670798);
    SpeechBubblePlayableAsset.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubblePlayableAsset>.NativeClassPtr, 100670799);
    SpeechBubblePlayableAsset.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubblePlayableAsset>.NativeClassPtr, 100670800);
    SpeechBubblePlayableAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubblePlayableAsset>.NativeClassPtr, 100670801);
  }

  public override unsafe double duration
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88302, XrefRangeEnd = 88303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpeechBubblePlayableAsset.NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe ClipCaps clipCaps
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpeechBubblePlayableAsset.NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ClipCaps*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float TextDuration
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpeechBubblePlayableAsset.NativeMethodInfoPtr_get_TextDuration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe string Text
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpeechBubblePlayableAsset.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88303, XrefRangeEnd = 88329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Playable CreatePlayable(PlayableGraph graph, GameObject owner)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &graph;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) owner);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpeechBubblePlayableAsset.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Playable*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88329, XrefRangeEnd = 88334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpeechBubblePlayableAsset()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeechBubblePlayableAsset>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubblePlayableAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SpeechBubbleBehavior template
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubblePlayableAsset.NativeFieldInfoPtr_template));
      return num == IntPtr.Zero ? (SpeechBubbleBehavior) null : Il2CppObjectPool.Get<SpeechBubbleBehavior>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubblePlayableAsset.NativeFieldInfoPtr_template), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float textDuration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubblePlayableAsset.NativeFieldInfoPtr_textDuration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubblePlayableAsset.NativeFieldInfoPtr_textDuration)) = value;
    }
  }

  public unsafe string text
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubblePlayableAsset.NativeFieldInfoPtr_text)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubblePlayableAsset.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe float DelayBetweenChars
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubblePlayableAsset.NativeFieldInfoPtr_DelayBetweenChars));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubblePlayableAsset.NativeFieldInfoPtr_DelayBetweenChars)) = value;
    }
  }

  public unsafe float DelayAfterPunctuatoin
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubblePlayableAsset.NativeFieldInfoPtr_DelayAfterPunctuatoin));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubblePlayableAsset.NativeFieldInfoPtr_DelayAfterPunctuatoin)) = value;
    }
  }
}
