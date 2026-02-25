// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.Elements.UISpeechBubble
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using SadCatStudios.Effects;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.UI.Elements;

public class UISpeechBubble(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_speakerTextMesh;
  private static readonly System.IntPtr NativeFieldInfoPtr_speechTypewriter;
  private static readonly System.IntPtr NativeFieldInfoPtr_promtFollow;
  private static readonly System.IntPtr NativeFieldInfoPtr_continueTextLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_bubbleBackground;
  private static readonly System.IntPtr NativeFieldInfoPtr_bubbleOrigin;
  private static readonly System.IntPtr NativeFieldInfoPtr_typeWriter;
  private static readonly System.IntPtr NativeFieldInfoPtr_componentCache;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentFromPoolable_Public_Virtual_Final_New_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGameObject_Public_Virtual_Final_New_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTransform_Public_Virtual_Final_New_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeWriter_Public_UITextTypeWriter_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_ObjectPool_FloatReference_IImpactPositionProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSpeechLine_Public_Void_Transform_Renderer_String_String_Boolean_Vector3_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LastCharTime_Public_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTime_Public_Boolean_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetContinueLabelEnabled_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UISpeechBubble()
  {
    Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI.Elements", nameof (UISpeechBubble));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr);
    UISpeechBubble.NativeFieldInfoPtr_speakerTextMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, nameof (speakerTextMesh));
    UISpeechBubble.NativeFieldInfoPtr_speechTypewriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, nameof (speechTypewriter));
    UISpeechBubble.NativeFieldInfoPtr_promtFollow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, nameof (promtFollow));
    UISpeechBubble.NativeFieldInfoPtr_continueTextLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, nameof (continueTextLabel));
    UISpeechBubble.NativeFieldInfoPtr_bubbleBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, nameof (bubbleBackground));
    UISpeechBubble.NativeFieldInfoPtr_bubbleOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, nameof (bubbleOrigin));
    UISpeechBubble.NativeFieldInfoPtr_typeWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, nameof (typeWriter));
    UISpeechBubble.NativeFieldInfoPtr_componentCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, nameof (componentCache));
    UISpeechBubble.NativeMethodInfoPtr_GetComponentFromPoolable_Public_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, 100672483);
    UISpeechBubble.NativeMethodInfoPtr_GetGameObject_Public_Virtual_Final_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, 100672484);
    UISpeechBubble.NativeMethodInfoPtr_GetTransform_Public_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, 100672485);
    UISpeechBubble.NativeMethodInfoPtr_GetTypeWriter_Public_UITextTypeWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, 100672486);
    UISpeechBubble.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_ObjectPool_FloatReference_IImpactPositionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, 100672487);
    UISpeechBubble.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, 100672488);
    UISpeechBubble.NativeMethodInfoPtr_SetSpeechLine_Public_Void_Transform_Renderer_String_String_Boolean_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, 100672489);
    UISpeechBubble.NativeMethodInfoPtr_LastCharTime_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, 100672490);
    UISpeechBubble.NativeMethodInfoPtr_ProcessTime_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, 100672491);
    UISpeechBubble.NativeMethodInfoPtr_SetContinueLabelEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, 100672492);
    UISpeechBubble.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr, 100672493);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101539, XrefRangeEnd = 101543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe T GetComponentFromPoolable<T>() where T : MonoBehaviour
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UISpeechBubble.MethodInfoStoreGeneric_GetComponentFromPoolable_Public_Virtual_Final_New_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 22237, RefRangeEnd = 22242, XrefRangeStart = 22237, XrefRangeEnd = 22242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe GameObject GetGameObject()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UISpeechBubble.NativeMethodInfoPtr_GetGameObject_Public_Virtual_Final_New_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 22243, RefRangeEnd = 22246, XrefRangeStart = 22243, XrefRangeEnd = 22246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Transform GetTransform()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UISpeechBubble.NativeMethodInfoPtr_GetTransform_Public_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
  }

  [CallerCount(0)]
  public unsafe UITextTypeWriter GetTypeWriter()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UISpeechBubble.NativeMethodInfoPtr_GetTypeWriter_Public_UITextTypeWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UITextTypeWriter) null : Il2CppObjectPool.Get<UITextTypeWriter>(num3);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Init(
    ObjectPool pool,
    FloatReference lifetime = null,
    IImpactPositionProvider positionProvider = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pool);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lifetime);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positionProvider);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISpeechBubble.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_ObjectPool_FloatReference_IImpactPositionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101543, XrefRangeEnd = 101546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISpeechBubble.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 101555, RefRangeEnd = 101556, XrefRangeStart = 101546, XrefRangeEnd = 101555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSpeechLine(
    Transform speakerTransform,
    Renderer renderer,
    string speakerName,
    string speech,
    bool stableY,
    Vector3 offset = default (Vector3),
    bool showSpeakerName = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) speakerTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderer);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(speakerName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(speech);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &stableY;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &showSpeakerName;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISpeechBubble.NativeMethodInfoPtr_SetSpeechLine_Public_Void_Transform_Renderer_String_String_Boolean_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 101560, RefRangeEnd = 101561, XrefRangeStart = 101556, XrefRangeEnd = 101560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float LastCharTime()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UISpeechBubble.NativeMethodInfoPtr_LastCharTime_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 101563, RefRangeEnd = 101566, XrefRangeStart = 101561, XrefRangeEnd = 101563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ProcessTime(float time)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &time
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UISpeechBubble.NativeMethodInfoPtr_ProcessTime_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101566, XrefRangeEnd = 101569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetContinueLabelEnabled(bool enabled)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &enabled
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISpeechBubble.NativeMethodInfoPtr_SetContinueLabelEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101569, XrefRangeEnd = 101576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UISpeechBubble()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISpeechBubble.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe TextMeshProUGUI speakerTextMesh
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_speakerTextMesh));
      return num == System.IntPtr.Zero ? (TextMeshProUGUI) null : Il2CppObjectPool.Get<TextMeshProUGUI>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_speakerTextMesh), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UITextTypeWriter speechTypewriter
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_speechTypewriter));
      return num == System.IntPtr.Zero ? (UITextTypeWriter) null : Il2CppObjectPool.Get<UITextTypeWriter>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_speechTypewriter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIPromtFollow promtFollow
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_promtFollow));
      return num == System.IntPtr.Zero ? (UIPromtFollow) null : Il2CppObjectPool.Get<UIPromtFollow>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_promtFollow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextMeshProUGUI continueTextLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_continueTextLabel));
      return num == System.IntPtr.Zero ? (TextMeshProUGUI) null : Il2CppObjectPool.Get<TextMeshProUGUI>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_continueTextLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image bubbleBackground
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_bubbleBackground));
      return num == System.IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_bubbleBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image bubbleOrigin
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_bubbleOrigin));
      return num == System.IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_bubbleOrigin), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UITextTypeWriter typeWriter
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_typeWriter));
      return num == System.IntPtr.Zero ? (UITextTypeWriter) null : Il2CppObjectPool.Get<UITextTypeWriter>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_typeWriter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<Il2CppSystem.Type, MonoBehaviour> componentCache
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_componentCache));
      return num == System.IntPtr.Zero ? (Dictionary<Il2CppSystem.Type, MonoBehaviour>) null : Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, MonoBehaviour>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISpeechBubble.NativeFieldInfoPtr_componentCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  private sealed class MethodInfoStoreGeneric_GetComponentFromPoolable_Public_Virtual_Final_New_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UISpeechBubble.NativeMethodInfoPtr_GetComponentFromPoolable_Public_Virtual_Final_New_T_0, Il2CppClassPointerStore<UISpeechBubble>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
