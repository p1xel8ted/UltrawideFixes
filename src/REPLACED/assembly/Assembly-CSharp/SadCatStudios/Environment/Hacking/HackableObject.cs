// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Environment.Hacking.HackableObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using SadCatStudios.Character;
using SadCatStudios.Foundation;
using SadCatStudios.Triggers;
using Sirenix.OdinInspector;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SadCatStudios.Environment.Hacking;

public class HackableObject(System.IntPtr pointer) : SerializedMonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_hackableRenderer;
  private static readonly System.IntPtr NativeFieldInfoPtr_hackCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_cooldown;
  private static readonly System.IntPtr NativeFieldInfoPtr_hackChangedStateEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_onCooldown;
  private static readonly System.IntPtr NativeFieldInfoPtr_highlightRenderers;
  private static readonly System.IntPtr NativeFieldInfoPtr_hackOnce;
  private static readonly System.IntPtr NativeFieldInfoPtr_hacked;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HackableRenderer_Public_get_Renderer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OnCooldown_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ZoneInteractionType_Public_Virtual_Final_New_get_InteractionIcon_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCooldownOverride_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnableSelectorSprite_Public_Virtual_New_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectorColor_Public_Void_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hack_Public_Virtual_New_Void_CharacterInteractionController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasInteracted_Public_Virtual_Final_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Interact_Public_Virtual_Final_New_Void_CharacterInteractionController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanBeInteracted_Public_Virtual_Final_New_Boolean_CharacterInteractionController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartCooldown_Protected_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoCooldown_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static HackableObject()
  {
    Il2CppClassPointerStore<HackableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Environment.Hacking", nameof (HackableObject));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HackableObject>.NativeClassPtr);
    HackableObject.NativeFieldInfoPtr_hackableRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, nameof (hackableRenderer));
    HackableObject.NativeFieldInfoPtr_hackCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, nameof (hackCallback));
    HackableObject.NativeFieldInfoPtr_cooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, nameof (cooldown));
    HackableObject.NativeFieldInfoPtr_hackChangedStateEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, nameof (hackChangedStateEvent));
    HackableObject.NativeFieldInfoPtr_onCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, nameof (onCooldown));
    HackableObject.NativeFieldInfoPtr_highlightRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, nameof (highlightRenderers));
    HackableObject.NativeFieldInfoPtr_hackOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, nameof (hackOnce));
    HackableObject.NativeFieldInfoPtr_hacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, nameof (hacked));
    HackableObject.NativeMethodInfoPtr_get_HackableRenderer_Public_get_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, 100676162);
    HackableObject.NativeMethodInfoPtr_get_OnCooldown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, 100676163);
    HackableObject.NativeMethodInfoPtr_get_ZoneInteractionType_Public_Virtual_Final_New_get_InteractionIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, 100676164);
    HackableObject.NativeMethodInfoPtr_SetCooldownOverride_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, 100676165);
    HackableObject.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, 100676166);
    HackableObject.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, 100676167);
    HackableObject.NativeMethodInfoPtr_EnableSelectorSprite_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, 100676168);
    HackableObject.NativeMethodInfoPtr_SetSelectorColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, 100676169);
    HackableObject.NativeMethodInfoPtr_Hack_Public_Virtual_New_Void_CharacterInteractionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, 100676170);
    HackableObject.NativeMethodInfoPtr_HasInteracted_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, 100676171);
    HackableObject.NativeMethodInfoPtr_Interact_Public_Virtual_Final_New_Void_CharacterInteractionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, 100676172);
    HackableObject.NativeMethodInfoPtr_CanBeInteracted_Public_Virtual_Final_New_Boolean_CharacterInteractionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, 100676173);
    HackableObject.NativeMethodInfoPtr_StartCooldown_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, 100676174);
    HackableObject.NativeMethodInfoPtr_DoCooldown_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, 100676175);
    HackableObject.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, 100676176);
    HackableObject.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, 100676177);
    HackableObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, 100676178);
  }

  public unsafe Renderer HackableRenderer
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64622, RefRangeEnd = 64623, XrefRangeStart = 64622, XrefRangeEnd = 64623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HackableObject.NativeMethodInfoPtr_get_HackableRenderer_Public_get_Renderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Renderer) null : Il2CppObjectPool.Get<Renderer>(num3);
    }
  }

  public unsafe bool OnCooldown
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HackableObject.NativeMethodInfoPtr_get_OnCooldown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe InteractionZone.InteractionIcon ZoneInteractionType
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HackableObject.NativeMethodInfoPtr_get_ZoneInteractionType_Public_Virtual_Final_New_get_InteractionIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(InteractionZone.InteractionIcon*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121918, XrefRangeEnd = 121919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetCooldownOverride(bool value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HackableObject.NativeMethodInfoPtr_SetCooldownOverride_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121919, XrefRangeEnd = 121933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HackableObject.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121933, XrefRangeEnd = 121944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HackableObject.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121944, XrefRangeEnd = 121946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EnableSelectorSprite(bool enable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &enable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HackableObject.NativeMethodInfoPtr_EnableSelectorSprite_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 121948, RefRangeEnd = 121949, XrefRangeStart = 121946, XrefRangeEnd = 121948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSelectorColor(Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &color
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HackableObject.NativeMethodInfoPtr_SetSelectorColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Hack(
    CharacterInteractionController interactionController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactionController)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HackableObject.NativeMethodInfoPtr_Hack_Public_Virtual_New_Void_CharacterInteractionController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121949, XrefRangeEnd = 121954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool HasInteracted()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HackableObject.NativeMethodInfoPtr_HasInteracted_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe void Interact(
    CharacterInteractionController interactionController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactionController)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HackableObject.NativeMethodInfoPtr_Interact_Public_Virtual_Final_New_Void_CharacterInteractionController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe bool CanBeInteracted(
    CharacterInteractionController interactionController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactionController)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HackableObject.NativeMethodInfoPtr_CanBeInteracted_Public_Virtual_Final_New_Boolean_CharacterInteractionController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121954, XrefRangeEnd = 121959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartCooldown()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HackableObject.NativeMethodInfoPtr_StartCooldown_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121959, XrefRangeEnd = 121963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator DoCooldown()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HackableObject.NativeMethodInfoPtr_DoCooldown_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121963, XrefRangeEnd = 121965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object Serialize(ICheckpointSender checkpointSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkpointSender)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HackableObject.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121965, XrefRangeEnd = 121967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Deserialize(Il2CppSystem.Object data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HackableObject.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 16301, RefRangeEnd = 16305, XrefRangeStart = 16301, XrefRangeEnd = 16305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HackableObject()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HackableObject>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HackableObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Renderer hackableRenderer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackableObject.NativeFieldInfoPtr_hackableRenderer));
      return num == System.IntPtr.Zero ? (Renderer) null : Il2CppObjectPool.Get<Renderer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HackableObject.NativeFieldInfoPtr_hackableRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent hackCallback
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackableObject.NativeFieldInfoPtr_hackCallback));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HackableObject.NativeFieldInfoPtr_hackCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float cooldown
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackableObject.NativeFieldInfoPtr_cooldown));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackableObject.NativeFieldInfoPtr_cooldown)) = value;
    }
  }

  public unsafe EventReference hackChangedStateEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackableObject.NativeFieldInfoPtr_hackChangedStateEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackableObject.NativeFieldInfoPtr_hackChangedStateEvent)) = value;
    }
  }

  public unsafe bool onCooldown
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackableObject.NativeFieldInfoPtr_onCooldown));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackableObject.NativeFieldInfoPtr_onCooldown)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<SpriteRenderer> highlightRenderers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackableObject.NativeFieldInfoPtr_highlightRenderers));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<SpriteRenderer>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteRenderer>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HackableObject.NativeFieldInfoPtr_highlightRenderers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool hackOnce
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackableObject.NativeFieldInfoPtr_hackOnce));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackableObject.NativeFieldInfoPtr_hackOnce)) = value;
    }
  }

  public unsafe bool hacked
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackableObject.NativeFieldInfoPtr_hacked));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackableObject.NativeFieldInfoPtr_hacked)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Environment.Hacking.HackableObject+<DoCooldown>d__24")]
  public sealed class _DoCooldown_d__24(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _DoCooldown_d__24()
    {
      Il2CppClassPointerStore<HackableObject._DoCooldown_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HackableObject>.NativeClassPtr, "<DoCooldown>d__24");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HackableObject._DoCooldown_d__24>.NativeClassPtr);
      HackableObject._DoCooldown_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackableObject._DoCooldown_d__24>.NativeClassPtr, "<>1__state");
      HackableObject._DoCooldown_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackableObject._DoCooldown_d__24>.NativeClassPtr, "<>2__current");
      HackableObject._DoCooldown_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackableObject._DoCooldown_d__24>.NativeClassPtr, "<>4__this");
      HackableObject._DoCooldown_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject._DoCooldown_d__24>.NativeClassPtr, 100676179);
      HackableObject._DoCooldown_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject._DoCooldown_d__24>.NativeClassPtr, 100676180);
      HackableObject._DoCooldown_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject._DoCooldown_d__24>.NativeClassPtr, 100676181);
      HackableObject._DoCooldown_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject._DoCooldown_d__24>.NativeClassPtr, 100676182);
      HackableObject._DoCooldown_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject._DoCooldown_d__24>.NativeClassPtr, 100676183);
      HackableObject._DoCooldown_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackableObject._DoCooldown_d__24>.NativeClassPtr, 100676184);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _DoCooldown_d__24(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HackableObject._DoCooldown_d__24>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(HackableObject._DoCooldown_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(HackableObject._DoCooldown_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121909, XrefRangeEnd = 121913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HackableObject._DoCooldown_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HackableObject._DoCooldown_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121913, XrefRangeEnd = 121918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(HackableObject._DoCooldown_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HackableObject._DoCooldown_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackableObject._DoCooldown_d__24.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackableObject._DoCooldown_d__24.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackableObject._DoCooldown_d__24.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HackableObject._DoCooldown_d__24.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HackableObject __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackableObject._DoCooldown_d__24.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (HackableObject) null : Il2CppObjectPool.Get<HackableObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HackableObject._DoCooldown_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
