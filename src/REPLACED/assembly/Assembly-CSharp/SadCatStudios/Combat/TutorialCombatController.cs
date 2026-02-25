// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.TutorialCombatController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using SadCatStudios.AI;
using SadCatStudios.Character;
using SadCatStudios.Foundation.Events;
using SadCatStudios.FSM;
using SadCatStudios.UI;
using SadCatStudios.UI.Elements;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class TutorialCombatController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_playerReference;
  private static readonly System.IntPtr NativeFieldInfoPtr_rollPromptRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_counterHitPromptRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_healPromptRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_meleePromptRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_rollState;
  private static readonly System.IntPtr NativeFieldInfoPtr_counterState;
  private static readonly System.IntPtr NativeFieldInfoPtr_healingState;
  private static readonly System.IntPtr NativeFieldInfoPtr_attackState;
  private static readonly System.IntPtr NativeFieldInfoPtr_aiController;
  private static readonly System.IntPtr NativeFieldInfoPtr_animationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_deathController;
  private static readonly System.IntPtr NativeFieldInfoPtr_running;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventDisposable;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBeginReset_Private_Void_BeginResetToCheckpointEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TutorialSequence_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TutorialCombatController()
  {
    Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (TutorialCombatController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr);
    TutorialCombatController.NativeFieldInfoPtr_playerReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, nameof (playerReference));
    TutorialCombatController.NativeFieldInfoPtr_rollPromptRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, nameof (rollPromptRef));
    TutorialCombatController.NativeFieldInfoPtr_counterHitPromptRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, nameof (counterHitPromptRef));
    TutorialCombatController.NativeFieldInfoPtr_healPromptRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, nameof (healPromptRef));
    TutorialCombatController.NativeFieldInfoPtr_meleePromptRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, nameof (meleePromptRef));
    TutorialCombatController.NativeFieldInfoPtr_rollState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, nameof (rollState));
    TutorialCombatController.NativeFieldInfoPtr_counterState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, nameof (counterState));
    TutorialCombatController.NativeFieldInfoPtr_healingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, nameof (healingState));
    TutorialCombatController.NativeFieldInfoPtr_attackState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, nameof (attackState));
    TutorialCombatController.NativeFieldInfoPtr_aiController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, nameof (aiController));
    TutorialCombatController.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, nameof (animationController));
    TutorialCombatController.NativeFieldInfoPtr_deathController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, nameof (deathController));
    TutorialCombatController.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, nameof (running));
    TutorialCombatController.NativeFieldInfoPtr_eventDisposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, nameof (eventDisposable));
    TutorialCombatController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, 100677741);
    TutorialCombatController.NativeMethodInfoPtr_OnBeginReset_Private_Void_BeginResetToCheckpointEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, 100677742);
    TutorialCombatController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, 100677743);
    TutorialCombatController.NativeMethodInfoPtr_TutorialSequence_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, 100677744);
    TutorialCombatController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, 100677745);
    TutorialCombatController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, 100677746);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131227, XrefRangeEnd = 131255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TutorialCombatController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131255, XrefRangeEnd = 131257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnBeginReset(BeginResetToCheckpointEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TutorialCombatController.NativeMethodInfoPtr_OnBeginReset_Private_Void_BeginResetToCheckpointEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131257, XrefRangeEnd = 131260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TutorialCombatController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131260, XrefRangeEnd = 131264 /*0x0200C0*/, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator TutorialSequence()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TutorialCombatController.NativeMethodInfoPtr_TutorialSequence_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131264 /*0x0200C0*/, XrefRangeEnd = 131278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TutorialCombatController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TutorialCombatController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TutorialCombatController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GuidReference playerReference
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_playerReference));
      return num == System.IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_playerReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef rollPromptRef
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_rollPromptRef));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_rollPromptRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef counterHitPromptRef
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_counterHitPromptRef));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_counterHitPromptRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef healPromptRef
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_healPromptRef));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_healPromptRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef meleePromptRef
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_meleePromptRef));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_meleePromptRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SadCatStudios.FSM.State rollState
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_rollState));
      return num == System.IntPtr.Zero ? (SadCatStudios.FSM.State) null : Il2CppObjectPool.Get<SadCatStudios.FSM.State>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_rollState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SadCatStudios.FSM.State counterState
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_counterState));
      return num == System.IntPtr.Zero ? (SadCatStudios.FSM.State) null : Il2CppObjectPool.Get<SadCatStudios.FSM.State>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_counterState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SadCatStudios.FSM.State healingState
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_healingState));
      return num == System.IntPtr.Zero ? (SadCatStudios.FSM.State) null : Il2CppObjectPool.Get<SadCatStudios.FSM.State>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_healingState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SadCatStudios.FSM.State attackState
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_attackState));
      return num == System.IntPtr.Zero ? (SadCatStudios.FSM.State) null : Il2CppObjectPool.Get<SadCatStudios.FSM.State>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_attackState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAIController aiController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_aiController));
      return num == System.IntPtr.Zero ? (CharacterAIController) null : Il2CppObjectPool.Get<CharacterAIController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_aiController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_animationController));
      return num == System.IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterDeathController deathController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_deathController));
      return num == System.IntPtr.Zero ? (CharacterDeathController) null : Il2CppObjectPool.Get<CharacterDeathController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_deathController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool running
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_running));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_running)) = value;
    }
  }

  public unsafe Il2CppSystem.IDisposable eventDisposable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_eventDisposable));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController.NativeFieldInfoPtr_eventDisposable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.TutorialCombatController+<TutorialSequence>d__17")]
  public sealed class _TutorialSequence_d__17(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__playerStateController_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__attackWeights_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__promptsManager_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__counter_5__5;
    private static readonly System.IntPtr NativeFieldInfoPtr__counterPrompt_5__6;
    private static readonly System.IntPtr NativeFieldInfoPtr__promptCounterText_5__7;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _TutorialSequence_d__17()
    {
      Il2CppClassPointerStore<TutorialCombatController._TutorialSequence_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCombatController>.NativeClassPtr, "<TutorialSequence>d__17");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCombatController._TutorialSequence_d__17>.NativeClassPtr);
      TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController._TutorialSequence_d__17>.NativeClassPtr, "<>1__state");
      TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController._TutorialSequence_d__17>.NativeClassPtr, "<>2__current");
      TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController._TutorialSequence_d__17>.NativeClassPtr, "<>4__this");
      TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr__playerStateController_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController._TutorialSequence_d__17>.NativeClassPtr, "<playerStateController>5__2");
      TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr__attackWeights_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController._TutorialSequence_d__17>.NativeClassPtr, "<attackWeights>5__3");
      TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr__promptsManager_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController._TutorialSequence_d__17>.NativeClassPtr, "<promptsManager>5__4");
      TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr__counter_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController._TutorialSequence_d__17>.NativeClassPtr, "<counter>5__5");
      TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr__counterPrompt_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController._TutorialSequence_d__17>.NativeClassPtr, "<counterPrompt>5__6");
      TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr__promptCounterText_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCombatController._TutorialSequence_d__17>.NativeClassPtr, "<promptCounterText>5__7");
      TutorialCombatController._TutorialSequence_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCombatController._TutorialSequence_d__17>.NativeClassPtr, 100677747);
      TutorialCombatController._TutorialSequence_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCombatController._TutorialSequence_d__17>.NativeClassPtr, 100677748);
      TutorialCombatController._TutorialSequence_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCombatController._TutorialSequence_d__17>.NativeClassPtr, 100677749);
      TutorialCombatController._TutorialSequence_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCombatController._TutorialSequence_d__17>.NativeClassPtr, 100677750);
      TutorialCombatController._TutorialSequence_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCombatController._TutorialSequence_d__17>.NativeClassPtr, 100677751);
      TutorialCombatController._TutorialSequence_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCombatController._TutorialSequence_d__17>.NativeClassPtr, 100677752);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _TutorialSequence_d__17(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCombatController._TutorialSequence_d__17>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TutorialCombatController._TutorialSequence_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TutorialCombatController._TutorialSequence_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131213, XrefRangeEnd = 131222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TutorialCombatController._TutorialSequence_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TutorialCombatController._TutorialSequence_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131222, XrefRangeEnd = 131227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TutorialCombatController._TutorialSequence_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TutorialCombatController._TutorialSequence_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TutorialCombatController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (TutorialCombatController) null : Il2CppObjectPool.Get<TutorialCombatController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AbilityStateController _playerStateController_5__2
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr__playerStateController_5__2));
        return num == System.IntPtr.Zero ? (AbilityStateController) null : Il2CppObjectPool.Get<AbilityStateController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr__playerStateController_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AttackWeigths _attackWeights_5__3
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr__attackWeights_5__3));
        return num == System.IntPtr.Zero ? (AttackWeigths) null : Il2CppObjectPool.Get<AttackWeigths>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr__attackWeights_5__3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIPromptsManager _promptsManager_5__4
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr__promptsManager_5__4));
        return num == System.IntPtr.Zero ? (UIPromptsManager) null : Il2CppObjectPool.Get<UIPromptsManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr__promptsManager_5__4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _counter_5__5
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr__counter_5__5));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr__counter_5__5)) = value;
      }
    }

    public unsafe UIButtonPrompt _counterPrompt_5__6
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr__counterPrompt_5__6));
        return num == System.IntPtr.Zero ? (UIButtonPrompt) null : Il2CppObjectPool.Get<UIButtonPrompt>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr__counterPrompt_5__6), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _promptCounterText_5__7
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr__promptCounterText_5__7)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCombatController._TutorialSequence_d__17.NativeFieldInfoPtr__promptCounterText_5__7), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
