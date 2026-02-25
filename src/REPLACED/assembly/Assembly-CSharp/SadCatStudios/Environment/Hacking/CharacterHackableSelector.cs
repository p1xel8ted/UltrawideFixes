// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Environment.Hacking.CharacterHackableSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using MessagePipe;
using SadCatStudios.Character;
using SadCatStudios.Foundation.Events;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Environment.Hacking;

public class CharacterHackableSelector(System.IntPtr pointer) : 
  LocalSingletonBehaviour<CharacterHackableSelector>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_highlightColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_cooldownColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_interactionController;
  private static readonly System.IntPtr NativeFieldInfoPtr_hackables;
  private static readonly System.IntPtr NativeFieldInfoPtr_selectables;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventDisposable;
  private static readonly System.IntPtr NativeFieldInfoPtr_farHackablesPublisher;
  private static readonly System.IntPtr NativeFieldInfoPtr_selectedIndex;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AnyHackableInRange_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterHackableObject_Public_Void_HackableObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterHackableObject_Public_Void_HackableObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Select_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GameStateChanged_Private_Void_GameStateChangedEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Int32_Vector3_byref___c__DisplayClass17_0_0;

  static CharacterHackableSelector()
  {
    Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Environment.Hacking", nameof (CharacterHackableSelector));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr);
    CharacterHackableSelector.NativeFieldInfoPtr_defaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, nameof (defaultColor));
    CharacterHackableSelector.NativeFieldInfoPtr_highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, nameof (highlightColor));
    CharacterHackableSelector.NativeFieldInfoPtr_cooldownColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, nameof (cooldownColor));
    CharacterHackableSelector.NativeFieldInfoPtr_interactionController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, nameof (interactionController));
    CharacterHackableSelector.NativeFieldInfoPtr_hackables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, nameof (hackables));
    CharacterHackableSelector.NativeFieldInfoPtr_selectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, nameof (selectables));
    CharacterHackableSelector.NativeFieldInfoPtr_eventDisposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, nameof (eventDisposable));
    CharacterHackableSelector.NativeFieldInfoPtr_farHackablesPublisher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, nameof (farHackablesPublisher));
    CharacterHackableSelector.NativeFieldInfoPtr_selectedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, nameof (selectedIndex));
    CharacterHackableSelector.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, 100676132);
    CharacterHackableSelector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, 100676133);
    CharacterHackableSelector.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, 100676134);
    CharacterHackableSelector.NativeMethodInfoPtr_AnyHackableInRange_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, 100676135);
    CharacterHackableSelector.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, 100676136);
    CharacterHackableSelector.NativeMethodInfoPtr_RegisterHackableObject_Public_Void_HackableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, 100676137);
    CharacterHackableSelector.NativeMethodInfoPtr_UnregisterHackableObject_Public_Void_HackableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, 100676138);
    CharacterHackableSelector.NativeMethodInfoPtr_Select_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, 100676139);
    CharacterHackableSelector.NativeMethodInfoPtr_GameStateChanged_Private_Void_GameStateChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, 100676140);
    CharacterHackableSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, 100676141);
    CharacterHackableSelector.NativeMethodInfoPtr_Method_Internal_Static_Int32_Vector3_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, 100676142);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121616, XrefRangeEnd = 121619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoAwake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterHackableSelector.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121619, XrefRangeEnd = 121646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHackableSelector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121646, XrefRangeEnd = 121649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterHackableSelector.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 121668, RefRangeEnd = 121669, XrefRangeStart = 121649, XrefRangeEnd = 121668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool AnyHackableInRange()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHackableSelector.NativeMethodInfoPtr_AnyHackableInRange_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 121746, RefRangeEnd = 121747, XrefRangeStart = 121669, XrefRangeEnd = 121746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHackableSelector.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121747, XrefRangeEnd = 121756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RegisterHackableObject(HackableObject hackableObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hackableObject)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHackableSelector.NativeMethodInfoPtr_RegisterHackableObject_Public_Void_HackableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121756, XrefRangeEnd = 121760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnregisterHackableObject(HackableObject hackableObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hackableObject)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHackableSelector.NativeMethodInfoPtr_UnregisterHackableObject_Public_Void_HackableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 121788, RefRangeEnd = 121790, XrefRangeStart = 121760, XrefRangeEnd = 121788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Select()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHackableSelector.NativeMethodInfoPtr_Select_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121790, XrefRangeEnd = 121794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GameStateChanged(GameStateChangedEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHackableSelector.NativeMethodInfoPtr_GameStateChanged_Private_Void_GameStateChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121794, XrefRangeEnd = 121807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterHackableSelector()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHackableSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 121812, RefRangeEnd = 121820, XrefRangeStart = 121807, XrefRangeEnd = 121812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int Method_Internal_Static_Int32_Vector3_byref___c__DisplayClass17_0_0(
    Vector3 screenSide,
    ref CharacterHackableSelector.__c__DisplayClass17_0 _param1)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &screenSide;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) _param1);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHackableSelector.NativeMethodInfoPtr_Method_Internal_Static_Int32_Vector3_byref___c__DisplayClass17_0_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Color defaultColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.NativeFieldInfoPtr_defaultColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.NativeFieldInfoPtr_defaultColor)) = value;
    }
  }

  public unsafe Color highlightColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.NativeFieldInfoPtr_highlightColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.NativeFieldInfoPtr_highlightColor)) = value;
    }
  }

  public unsafe Color cooldownColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.NativeFieldInfoPtr_cooldownColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.NativeFieldInfoPtr_cooldownColor)) = value;
    }
  }

  public unsafe CharacterInteractionController interactionController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.NativeFieldInfoPtr_interactionController));
      return num == System.IntPtr.Zero ? (CharacterInteractionController) null : Il2CppObjectPool.Get<CharacterInteractionController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.NativeFieldInfoPtr_interactionController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<HackableObject> hackables
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.NativeFieldInfoPtr_hackables));
      return num == System.IntPtr.Zero ? (List<HackableObject>) null : Il2CppObjectPool.Get<List<HackableObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.NativeFieldInfoPtr_hackables), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<HackableObject> selectables
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.NativeFieldInfoPtr_selectables));
      return num == System.IntPtr.Zero ? (List<HackableObject>) null : Il2CppObjectPool.Get<List<HackableObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.NativeFieldInfoPtr_selectables), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.IDisposable eventDisposable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.NativeFieldInfoPtr_eventDisposable));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.NativeFieldInfoPtr_eventDisposable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IPublisher<FarHackablesIndicators> farHackablesPublisher
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.NativeFieldInfoPtr_farHackablesPublisher));
      return num == System.IntPtr.Zero ? (IPublisher<FarHackablesIndicators>) null : Il2CppObjectPool.Get<IPublisher<FarHackablesIndicators>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.NativeFieldInfoPtr_farHackablesPublisher), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int selectedIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.NativeFieldInfoPtr_selectedIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.NativeFieldInfoPtr_selectedIndex)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Environment.Hacking.CharacterHackableSelector+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__17_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GameStateChanged_b__17_1_Internal_Int32_HackableObject_HackableObject_0;

    static __c()
    {
      Il2CppClassPointerStore<CharacterHackableSelector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHackableSelector.__c>.NativeClassPtr);
      CharacterHackableSelector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector.__c>.NativeClassPtr, "<>9");
      CharacterHackableSelector.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector.__c>.NativeClassPtr, "<>9__17_1");
      CharacterHackableSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableSelector.__c>.NativeClassPtr, 100676144);
      CharacterHackableSelector.__c.NativeMethodInfoPtr__GameStateChanged_b__17_1_Internal_Int32_HackableObject_HackableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableSelector.__c>.NativeClassPtr, 100676145);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHackableSelector.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterHackableSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121461, XrefRangeEnd = 121466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _GameStateChanged_b__17_1(HackableObject x, HackableObject y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHackableSelector.__c.NativeMethodInfoPtr__GameStateChanged_b__17_1_Internal_Int32_HackableObject_HackableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe CharacterHackableSelector.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CharacterHackableSelector.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (CharacterHackableSelector.__c) null : Il2CppObjectPool.Get<CharacterHackableSelector.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CharacterHackableSelector.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Comparison<HackableObject> __9__17_1
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CharacterHackableSelector.__c.NativeFieldInfoPtr___9__17_1, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Comparison<HackableObject>) null : Il2CppObjectPool.Get<Il2CppSystem.Comparison<HackableObject>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CharacterHackableSelector.__c.NativeFieldInfoPtr___9__17_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Environment.Hacking.CharacterHackableSelector+<>c__DisplayClass17_0")]
  public sealed class __c__DisplayClass17_0 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_hackableObject;

    static __c__DisplayClass17_0()
    {
      Il2CppClassPointerStore<CharacterHackableSelector.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, "<>c__DisplayClass17_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHackableSelector.__c__DisplayClass17_0>.NativeClassPtr);
      CharacterHackableSelector.__c__DisplayClass17_0.NativeFieldInfoPtr_hackableObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector.__c__DisplayClass17_0>.NativeClassPtr, nameof (hackableObject));
    }

    public __c__DisplayClass17_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public __c__DisplayClass17_0()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHackableSelector.__c__DisplayClass17_0>.NativeClassPtr))
    {
    }

    public unsafe HackableObject hackableObject
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.__c__DisplayClass17_0.NativeFieldInfoPtr_hackableObject));
        return num == System.IntPtr.Zero ? (HackableObject) null : Il2CppObjectPool.Get<HackableObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector.__c__DisplayClass17_0.NativeFieldInfoPtr_hackableObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Environment.Hacking.CharacterHackableSelector+<GameStateChanged>d__17")]
  public sealed class _GameStateChanged_d__17 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_e;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _GameStateChanged_d__17()
    {
      Il2CppClassPointerStore<CharacterHackableSelector._GameStateChanged_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, "<GameStateChanged>d__17");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHackableSelector._GameStateChanged_d__17>.NativeClassPtr);
      CharacterHackableSelector._GameStateChanged_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector._GameStateChanged_d__17>.NativeClassPtr, "<>1__state");
      CharacterHackableSelector._GameStateChanged_d__17.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector._GameStateChanged_d__17>.NativeClassPtr, "<>t__builder");
      CharacterHackableSelector._GameStateChanged_d__17.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector._GameStateChanged_d__17>.NativeClassPtr, nameof (e));
      CharacterHackableSelector._GameStateChanged_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector._GameStateChanged_d__17>.NativeClassPtr, "<>4__this");
      CharacterHackableSelector._GameStateChanged_d__17.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector._GameStateChanged_d__17>.NativeClassPtr, "<>u__1");
      CharacterHackableSelector._GameStateChanged_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableSelector._GameStateChanged_d__17>.NativeClassPtr, 100676146);
      CharacterHackableSelector._GameStateChanged_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableSelector._GameStateChanged_d__17>.NativeClassPtr, 100676147);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121466, XrefRangeEnd = 121589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterHackableSelector._GameStateChanged_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterHackableSelector._GameStateChanged_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _GameStateChanged_d__17(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _GameStateChanged_d__17()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHackableSelector._GameStateChanged_d__17>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._GameStateChanged_d__17.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._GameStateChanged_d__17.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._GameStateChanged_d__17.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._GameStateChanged_d__17.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe GameStateChangedEvent e
    {
      get
      {
        return *(GameStateChangedEvent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._GameStateChanged_d__17.NativeFieldInfoPtr_e));
      }
      [param: In] set
      {
        *(GameStateChangedEvent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._GameStateChanged_d__17.NativeFieldInfoPtr_e)) = value;
      }
    }

    public unsafe CharacterHackableSelector __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._GameStateChanged_d__17.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterHackableSelector) null : Il2CppObjectPool.Get<CharacterHackableSelector>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._GameStateChanged_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._GameStateChanged_d__17.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._GameStateChanged_d__17.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Environment.Hacking.CharacterHackableSelector+<UnregisterHackableObject>d__15")]
  public sealed class _UnregisterHackableObject_d__15 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_hackableObject;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _UnregisterHackableObject_d__15()
    {
      Il2CppClassPointerStore<CharacterHackableSelector._UnregisterHackableObject_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHackableSelector>.NativeClassPtr, "<UnregisterHackableObject>d__15");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHackableSelector._UnregisterHackableObject_d__15>.NativeClassPtr);
      CharacterHackableSelector._UnregisterHackableObject_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector._UnregisterHackableObject_d__15>.NativeClassPtr, "<>1__state");
      CharacterHackableSelector._UnregisterHackableObject_d__15.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector._UnregisterHackableObject_d__15>.NativeClassPtr, "<>t__builder");
      CharacterHackableSelector._UnregisterHackableObject_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector._UnregisterHackableObject_d__15>.NativeClassPtr, "<>4__this");
      CharacterHackableSelector._UnregisterHackableObject_d__15.NativeFieldInfoPtr_hackableObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector._UnregisterHackableObject_d__15>.NativeClassPtr, nameof (hackableObject));
      CharacterHackableSelector._UnregisterHackableObject_d__15.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableSelector._UnregisterHackableObject_d__15>.NativeClassPtr, "<>u__1");
      CharacterHackableSelector._UnregisterHackableObject_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableSelector._UnregisterHackableObject_d__15>.NativeClassPtr, 100676148);
      CharacterHackableSelector._UnregisterHackableObject_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableSelector._UnregisterHackableObject_d__15>.NativeClassPtr, 100676149);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121589, XrefRangeEnd = 121616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterHackableSelector._UnregisterHackableObject_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterHackableSelector._UnregisterHackableObject_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _UnregisterHackableObject_d__15(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _UnregisterHackableObject_d__15()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHackableSelector._UnregisterHackableObject_d__15>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._UnregisterHackableObject_d__15.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._UnregisterHackableObject_d__15.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._UnregisterHackableObject_d__15.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._UnregisterHackableObject_d__15.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe CharacterHackableSelector __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._UnregisterHackableObject_d__15.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterHackableSelector) null : Il2CppObjectPool.Get<CharacterHackableSelector>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._UnregisterHackableObject_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HackableObject hackableObject
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._UnregisterHackableObject_d__15.NativeFieldInfoPtr_hackableObject));
        return num == System.IntPtr.Zero ? (HackableObject) null : Il2CppObjectPool.Get<HackableObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._UnregisterHackableObject_d__15.NativeFieldInfoPtr_hackableObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._UnregisterHackableObject_d__15.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableSelector._UnregisterHackableObject_d__15.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
