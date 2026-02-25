// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Triggers.InteractionElevatorZone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using SadCatStudios.Character;
using SadCatStudios.Environment;
using SadCatStudios.MovementPhysics;
using System.Runtime.InteropServices;
using UnityEngine.Playables;

#nullable disable
namespace SadCatStudios.Triggers;

public class InteractionElevatorZone(System.IntPtr pointer) : InteractionZone(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_elevator;
  private static readonly System.IntPtr NativeFieldInfoPtr_elevatorTargetPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_playInteractionClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_beforeEnterOpening;
  private static readonly System.IntPtr NativeFieldInfoPtr_enterOpeningTimeline;
  private static readonly System.IntPtr NativeFieldInfoPtr_afterEnterOpening;
  private static readonly System.IntPtr NativeFieldInfoPtr_beforeEnterClosing;
  private static readonly System.IntPtr NativeFieldInfoPtr_enterClosingTimeline;
  private static readonly System.IntPtr NativeFieldInfoPtr_exitOpeningTimeline;
  private static readonly System.IntPtr NativeFieldInfoPtr_afterExitOpening;
  private static readonly System.IntPtr NativeFieldInfoPtr_exitClosingTimeline;
  private static readonly System.IntPtr NativeFieldInfoPtr_beforeExitClosing;
  private static readonly System.IntPtr NativeFieldInfoPtr_bridgeObject;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerMustBeInside_Public_Virtual_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ZoneInteractionType_Public_Virtual_get_InteractionIcon_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasInteracted_Public_Virtual_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Interaction_Protected_Virtual_IEnumerator_CharacterInteractionController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_CharacterInteractionController_0;

  static InteractionElevatorZone()
  {
    Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Triggers", nameof (InteractionElevatorZone));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr);
    InteractionElevatorZone.NativeFieldInfoPtr_elevator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, nameof (elevator));
    InteractionElevatorZone.NativeFieldInfoPtr_elevatorTargetPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, nameof (elevatorTargetPoint));
    InteractionElevatorZone.NativeFieldInfoPtr_playInteractionClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, nameof (playInteractionClip));
    InteractionElevatorZone.NativeFieldInfoPtr_beforeEnterOpening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, nameof (beforeEnterOpening));
    InteractionElevatorZone.NativeFieldInfoPtr_enterOpeningTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, nameof (enterOpeningTimeline));
    InteractionElevatorZone.NativeFieldInfoPtr_afterEnterOpening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, nameof (afterEnterOpening));
    InteractionElevatorZone.NativeFieldInfoPtr_beforeEnterClosing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, nameof (beforeEnterClosing));
    InteractionElevatorZone.NativeFieldInfoPtr_enterClosingTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, nameof (enterClosingTimeline));
    InteractionElevatorZone.NativeFieldInfoPtr_exitOpeningTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, nameof (exitOpeningTimeline));
    InteractionElevatorZone.NativeFieldInfoPtr_afterExitOpening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, nameof (afterExitOpening));
    InteractionElevatorZone.NativeFieldInfoPtr_exitClosingTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, nameof (exitClosingTimeline));
    InteractionElevatorZone.NativeFieldInfoPtr_beforeExitClosing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, nameof (beforeExitClosing));
    InteractionElevatorZone.NativeFieldInfoPtr_bridgeObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, nameof (bridgeObject));
    InteractionElevatorZone.NativeMethodInfoPtr_get_PlayerMustBeInside_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, 100671691);
    InteractionElevatorZone.NativeMethodInfoPtr_get_ZoneInteractionType_Public_Virtual_get_InteractionIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, 100671692);
    InteractionElevatorZone.NativeMethodInfoPtr_HasInteracted_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, 100671693);
    InteractionElevatorZone.NativeMethodInfoPtr_Interaction_Protected_Virtual_IEnumerator_CharacterInteractionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, 100671694);
    InteractionElevatorZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, 100671695);
    InteractionElevatorZone.NativeMethodInfoPtr___n__0_Private_IEnumerator_CharacterInteractionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, 100671696 /*0x060020D0*/);
  }

  public override unsafe bool PlayerMustBeInside
  {
    [CallerCount(194), CachedScanResults(RefRangeStart = 65249, RefRangeEnd = 65443, XrefRangeStart = 65249, XrefRangeEnd = 65443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractionElevatorZone.NativeMethodInfoPtr_get_PlayerMustBeInside_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public override unsafe InteractionZone.InteractionIcon ZoneInteractionType
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractionElevatorZone.NativeMethodInfoPtr_get_ZoneInteractionType_Public_Virtual_get_InteractionIcon_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(InteractionZone.InteractionIcon*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95808, XrefRangeEnd = 95813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool HasInteracted()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractionElevatorZone.NativeMethodInfoPtr_HasInteracted_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95813, XrefRangeEnd = 95817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Interaction(
    CharacterInteractionController interactionController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactionController)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractionElevatorZone.NativeMethodInfoPtr_Interaction_Protected_Virtual_IEnumerator_CharacterInteractionController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95817, XrefRangeEnd = 95822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InteractionElevatorZone()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InteractionElevatorZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 95567, RefRangeEnd = 95570, XrefRangeStart = 95567, XrefRangeEnd = 95570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator __n__0(
    CharacterInteractionController interactionController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactionController)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InteractionElevatorZone.NativeMethodInfoPtr___n__0_Private_IEnumerator_CharacterInteractionController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  public unsafe PlatformPhysics elevator
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_elevator));
      return num == System.IntPtr.Zero ? (PlatformPhysics) null : Il2CppObjectPool.Get<PlatformPhysics>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_elevator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int elevatorTargetPoint
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_elevatorTargetPoint));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_elevatorTargetPoint)) = value;
    }
  }

  public unsafe bool playInteractionClip
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_playInteractionClip));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_playInteractionClip)) = value;
    }
  }

  public unsafe float beforeEnterOpening
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_beforeEnterOpening));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_beforeEnterOpening)) = value;
    }
  }

  public unsafe PlayableDirector enterOpeningTimeline
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_enterOpeningTimeline));
      return num == System.IntPtr.Zero ? (PlayableDirector) null : Il2CppObjectPool.Get<PlayableDirector>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_enterOpeningTimeline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float afterEnterOpening
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_afterEnterOpening));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_afterEnterOpening)) = value;
    }
  }

  public unsafe float beforeEnterClosing
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_beforeEnterClosing));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_beforeEnterClosing)) = value;
    }
  }

  public unsafe PlayableDirector enterClosingTimeline
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_enterClosingTimeline));
      return num == System.IntPtr.Zero ? (PlayableDirector) null : Il2CppObjectPool.Get<PlayableDirector>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_enterClosingTimeline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PlayableDirector exitOpeningTimeline
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_exitOpeningTimeline));
      return num == System.IntPtr.Zero ? (PlayableDirector) null : Il2CppObjectPool.Get<PlayableDirector>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_exitOpeningTimeline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float afterExitOpening
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_afterExitOpening));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_afterExitOpening)) = value;
    }
  }

  public unsafe PlayableDirector exitClosingTimeline
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_exitClosingTimeline));
      return num == System.IntPtr.Zero ? (PlayableDirector) null : Il2CppObjectPool.Get<PlayableDirector>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_exitClosingTimeline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float beforeExitClosing
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_beforeExitClosing));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_beforeExitClosing)) = value;
    }
  }

  public unsafe BridgeObject bridgeObject
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_bridgeObject));
      return num == System.IntPtr.Zero ? (BridgeObject) null : Il2CppObjectPool.Get<BridgeObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone.NativeFieldInfoPtr_bridgeObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Triggers.InteractionElevatorZone+<Interaction>d__18")]
  public sealed class _Interaction_d__18(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_interactionController;
    private static readonly System.IntPtr NativeFieldInfoPtr__hasEnterOpeningPipeline_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__hasEnterClosingPipeline_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__hasExitOpeningPipeline_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__hasExitClosingPipeline_5__5;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _Interaction_d__18()
    {
      Il2CppClassPointerStore<InteractionElevatorZone._Interaction_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractionElevatorZone>.NativeClassPtr, "<Interaction>d__18");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionElevatorZone._Interaction_d__18>.NativeClassPtr);
      InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone._Interaction_d__18>.NativeClassPtr, "<>1__state");
      InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone._Interaction_d__18>.NativeClassPtr, "<>2__current");
      InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone._Interaction_d__18>.NativeClassPtr, "<>4__this");
      InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr_interactionController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone._Interaction_d__18>.NativeClassPtr, nameof (interactionController));
      InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr__hasEnterOpeningPipeline_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone._Interaction_d__18>.NativeClassPtr, "<hasEnterOpeningPipeline>5__2");
      InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr__hasEnterClosingPipeline_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone._Interaction_d__18>.NativeClassPtr, "<hasEnterClosingPipeline>5__3");
      InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr__hasExitOpeningPipeline_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone._Interaction_d__18>.NativeClassPtr, "<hasExitOpeningPipeline>5__4");
      InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr__hasExitClosingPipeline_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionElevatorZone._Interaction_d__18>.NativeClassPtr, "<hasExitClosingPipeline>5__5");
      InteractionElevatorZone._Interaction_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionElevatorZone._Interaction_d__18>.NativeClassPtr, 100671697);
      InteractionElevatorZone._Interaction_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionElevatorZone._Interaction_d__18>.NativeClassPtr, 100671698);
      InteractionElevatorZone._Interaction_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionElevatorZone._Interaction_d__18>.NativeClassPtr, 100671699);
      InteractionElevatorZone._Interaction_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionElevatorZone._Interaction_d__18>.NativeClassPtr, 100671700);
      InteractionElevatorZone._Interaction_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionElevatorZone._Interaction_d__18>.NativeClassPtr, 100671701);
      InteractionElevatorZone._Interaction_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionElevatorZone._Interaction_d__18>.NativeClassPtr, 100671702);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Interaction_d__18(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionElevatorZone._Interaction_d__18>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InteractionElevatorZone._Interaction_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InteractionElevatorZone._Interaction_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95705, XrefRangeEnd = 95803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InteractionElevatorZone._Interaction_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InteractionElevatorZone._Interaction_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95803, XrefRangeEnd = 95808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InteractionElevatorZone._Interaction_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InteractionElevatorZone._Interaction_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InteractionElevatorZone __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (InteractionElevatorZone) null : Il2CppObjectPool.Get<InteractionElevatorZone>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterInteractionController interactionController
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr_interactionController));
        return num == System.IntPtr.Zero ? (CharacterInteractionController) null : Il2CppObjectPool.Get<CharacterInteractionController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr_interactionController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _hasEnterOpeningPipeline_5__2
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr__hasEnterOpeningPipeline_5__2));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr__hasEnterOpeningPipeline_5__2)) = value;
      }
    }

    public unsafe bool _hasEnterClosingPipeline_5__3
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr__hasEnterClosingPipeline_5__3));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr__hasEnterClosingPipeline_5__3)) = value;
      }
    }

    public unsafe bool _hasExitOpeningPipeline_5__4
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr__hasExitOpeningPipeline_5__4));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr__hasExitOpeningPipeline_5__4)) = value;
      }
    }

    public unsafe bool _hasExitClosingPipeline_5__5
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr__hasExitClosingPipeline_5__5));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionElevatorZone._Interaction_d__18.NativeFieldInfoPtr__hasExitClosingPipeline_5__5)) = value;
      }
    }
  }
}
