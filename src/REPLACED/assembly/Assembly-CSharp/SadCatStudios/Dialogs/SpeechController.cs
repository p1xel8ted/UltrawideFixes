// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.SpeechController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Dialogs.Articy;
using SadCatStudios.UI.Elements;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Dialogs;

public class SpeechController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_bubblePoolRef;
  private static readonly IntPtr NativeFieldInfoPtr_speakerRenderer;
  private static readonly IntPtr NativeFieldInfoPtr_offset;
  private static readonly IntPtr NativeFieldInfoPtr_speechMarker;
  private static readonly IntPtr NativeFieldInfoPtr_bubblePool;
  private static readonly IntPtr NativeFieldInfoPtr_actor;
  private static readonly IntPtr NativeFieldInfoPtr_text;
  private static readonly IntPtr NativeFieldInfoPtr_speechBubble;
  private static readonly IntPtr NativeFieldInfoPtr_lastRef;
  private static readonly IntPtr NativeMethodInfoPtr_get_LastLine_Public_get_ArticyRef_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_SpeakerRenderer_Public_get_Renderer_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_MarkerOffset_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ActorReference_Public_get_ActorReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_InitLine_Public_Void_ArticyRef_String_Boolean_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_InitLine_Public_Void_ArticyRef_0;
  private static readonly IntPtr NativeMethodInfoPtr_ReleaseLine_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ShowSpeechMarker_Public_GameObject_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessTime_Public_Boolean_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_LastCharTime_Public_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetContinueLabelEnabled_Public_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SpeechController()
  {
    Il2CppClassPointerStore<SpeechController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs", nameof (SpeechController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeechController>.NativeClassPtr);
    SpeechController.NativeFieldInfoPtr_bubblePoolRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, nameof (bubblePoolRef));
    SpeechController.NativeFieldInfoPtr_speakerRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, nameof (speakerRenderer));
    SpeechController.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, nameof (offset));
    SpeechController.NativeFieldInfoPtr_speechMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, nameof (speechMarker));
    SpeechController.NativeFieldInfoPtr_bubblePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, nameof (bubblePool));
    SpeechController.NativeFieldInfoPtr_actor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, nameof (actor));
    SpeechController.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, nameof (text));
    SpeechController.NativeFieldInfoPtr_speechBubble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, nameof (speechBubble));
    SpeechController.NativeFieldInfoPtr_lastRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, nameof (lastRef));
    SpeechController.NativeMethodInfoPtr_get_LastLine_Public_get_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, 100672642);
    SpeechController.NativeMethodInfoPtr_get_SpeakerRenderer_Public_get_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, 100672643);
    SpeechController.NativeMethodInfoPtr_get_MarkerOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, 100672644);
    SpeechController.NativeMethodInfoPtr_get_ActorReference_Public_get_ActorReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, 100672645);
    SpeechController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, 100672646);
    SpeechController.NativeMethodInfoPtr_InitLine_Public_Void_ArticyRef_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, 100672647);
    SpeechController.NativeMethodInfoPtr_InitLine_Public_Void_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, 100672648);
    SpeechController.NativeMethodInfoPtr_ReleaseLine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, 100672649);
    SpeechController.NativeMethodInfoPtr_ShowSpeechMarker_Public_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, 100672650);
    SpeechController.NativeMethodInfoPtr_ProcessTime_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, 100672651);
    SpeechController.NativeMethodInfoPtr_LastCharTime_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, 100672652);
    SpeechController.NativeMethodInfoPtr_SetContinueLabelEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, 100672653);
    SpeechController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechController>.NativeClassPtr, 100672654);
  }

  public unsafe ArticyRef LastLine
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64622, RefRangeEnd = 64623, XrefRangeStart = 64622, XrefRangeEnd = 64623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpeechController.NativeMethodInfoPtr_get_LastLine_Public_get_ArticyRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num3);
    }
  }

  public unsafe Renderer SpeakerRenderer
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpeechController.NativeMethodInfoPtr_get_SpeakerRenderer_Public_get_Renderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Renderer) null : Il2CppObjectPool.Get<Renderer>(num3);
    }
  }

  public unsafe Vector3 MarkerOffset
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpeechController.NativeMethodInfoPtr_get_MarkerOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ActorReference ActorReference
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpeechController.NativeMethodInfoPtr_get_ActorReference_Public_get_ActorReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ActorReference) null : Il2CppObjectPool.Get<ActorReference>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102447, XrefRangeEnd = 102450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpeechController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 102506, RefRangeEnd = 102508, XrefRangeStart = 102450, XrefRangeEnd = 102506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitLine(
    ArticyRef articyRef,
    string speaker,
    bool stableY = false,
    bool showSpeakerName = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) articyRef);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(speaker);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &stableY;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &showSpeakerName;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpeechController.NativeMethodInfoPtr_InitLine_Public_Void_ArticyRef_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 102524, RefRangeEnd = 102525, XrefRangeStart = 102508, XrefRangeEnd = 102524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitLine(ArticyRef articyRef)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) articyRef)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpeechController.NativeMethodInfoPtr_InitLine_Public_Void_ArticyRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 102536, RefRangeEnd = 102540, XrefRangeStart = 102525, XrefRangeEnd = 102536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ReleaseLine()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpeechController.NativeMethodInfoPtr_ReleaseLine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102540, XrefRangeEnd = 102552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GameObject ShowSpeechMarker(bool show)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &show
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpeechController.NativeMethodInfoPtr_ShowSpeechMarker_Public_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 102557, RefRangeEnd = 102558, XrefRangeStart = 102552, XrefRangeEnd = 102557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ProcessTime(float time)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &time
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpeechController.NativeMethodInfoPtr_ProcessTime_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102558, XrefRangeEnd = 102562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float LastCharTime()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpeechController.NativeMethodInfoPtr_LastCharTime_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102562, XrefRangeEnd = 102565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetContinueLabelEnabled(bool enabled)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &enabled
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpeechController.NativeMethodInfoPtr_SetContinueLabelEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpeechController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeechController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpeechController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GuidReference bubblePoolRef
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechController.NativeFieldInfoPtr_bubblePoolRef));
      return num == IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechController.NativeFieldInfoPtr_bubblePoolRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Renderer speakerRenderer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechController.NativeFieldInfoPtr_speakerRenderer));
      return num == IntPtr.Zero ? (Renderer) null : Il2CppObjectPool.Get<Renderer>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechController.NativeFieldInfoPtr_speakerRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 offset
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechController.NativeFieldInfoPtr_offset));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechController.NativeFieldInfoPtr_offset)) = value;
    }
  }

  public unsafe GameObject speechMarker
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechController.NativeFieldInfoPtr_speechMarker));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechController.NativeFieldInfoPtr_speechMarker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpeechBubblePool bubblePool
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechController.NativeFieldInfoPtr_bubblePool));
      return num == IntPtr.Zero ? (SpeechBubblePool) null : Il2CppObjectPool.Get<SpeechBubblePool>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechController.NativeFieldInfoPtr_bubblePool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ActorReference actor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechController.NativeFieldInfoPtr_actor));
      return num == IntPtr.Zero ? (ActorReference) null : Il2CppObjectPool.Get<ActorReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechController.NativeFieldInfoPtr_actor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string text
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechController.NativeFieldInfoPtr_text)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechController.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe UISpeechBubble speechBubble
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechController.NativeFieldInfoPtr_speechBubble));
      return num == IntPtr.Zero ? (UISpeechBubble) null : Il2CppObjectPool.Get<UISpeechBubble>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechController.NativeFieldInfoPtr_speechBubble), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef lastRef
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechController.NativeFieldInfoPtr_lastRef));
      return num == IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechController.NativeFieldInfoPtr_lastRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
