// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Triggers.InteractionBoltZone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using SadCatStudios.Character;
using System.Runtime.InteropServices;
using Unity.VisualScripting;

#nullable disable
namespace SadCatStudios.Triggers;

public class InteractionBoltZone(System.IntPtr pointer) : InteractionZone(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_InteractionEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonType;
  private static readonly System.IntPtr NativeFieldInfoPtr_enterType;
  private static readonly System.IntPtr NativeFieldInfoPtr_manualBreak;
  private static readonly System.IntPtr NativeFieldInfoPtr_flowMachine;
  private static readonly System.IntPtr NativeFieldInfoPtr_shouldBreak;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerMustBeInside_Public_Virtual_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Break_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasInteracted_Public_Virtual_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Interaction_Protected_Virtual_IEnumerator_CharacterInteractionController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_CharacterInteractionController_0;

  static InteractionBoltZone()
  {
    Il2CppClassPointerStore<InteractionBoltZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Triggers", nameof (InteractionBoltZone));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionBoltZone>.NativeClassPtr);
    InteractionBoltZone.NativeFieldInfoPtr_InteractionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionBoltZone>.NativeClassPtr, nameof (InteractionEvent));
    InteractionBoltZone.NativeFieldInfoPtr_buttonType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionBoltZone>.NativeClassPtr, nameof (buttonType));
    InteractionBoltZone.NativeFieldInfoPtr_enterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionBoltZone>.NativeClassPtr, nameof (enterType));
    InteractionBoltZone.NativeFieldInfoPtr_manualBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionBoltZone>.NativeClassPtr, nameof (manualBreak));
    InteractionBoltZone.NativeFieldInfoPtr_flowMachine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionBoltZone>.NativeClassPtr, nameof (flowMachine));
    InteractionBoltZone.NativeFieldInfoPtr_shouldBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionBoltZone>.NativeClassPtr, nameof (shouldBreak));
    InteractionBoltZone.NativeMethodInfoPtr_get_PlayerMustBeInside_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBoltZone>.NativeClassPtr, 100671628);
    InteractionBoltZone.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBoltZone>.NativeClassPtr, 100671629);
    InteractionBoltZone.NativeMethodInfoPtr_Break_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBoltZone>.NativeClassPtr, 100671630);
    InteractionBoltZone.NativeMethodInfoPtr_HasInteracted_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBoltZone>.NativeClassPtr, 100671631);
    InteractionBoltZone.NativeMethodInfoPtr_Interaction_Protected_Virtual_IEnumerator_CharacterInteractionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBoltZone>.NativeClassPtr, 100671632 /*0x06002090*/);
    InteractionBoltZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBoltZone>.NativeClassPtr, 100671633);
    InteractionBoltZone.NativeMethodInfoPtr___n__0_Private_IEnumerator_CharacterInteractionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBoltZone>.NativeClassPtr, 100671635);
  }

  public override unsafe bool PlayerMustBeInside
  {
    [CallerCount(194), CachedScanResults(RefRangeStart = 65249, RefRangeEnd = 65443, XrefRangeStart = 65249, XrefRangeEnd = 65443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractionBoltZone.NativeMethodInfoPtr_get_PlayerMustBeInside_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95545, XrefRangeEnd = 95548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InteractionBoltZone.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void Break()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InteractionBoltZone.NativeMethodInfoPtr_Break_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95548, XrefRangeEnd = 95553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool HasInteracted()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractionBoltZone.NativeMethodInfoPtr_HasInteracted_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95553, XrefRangeEnd = 95557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Interaction(
    CharacterInteractionController interactionController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactionController)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractionBoltZone.NativeMethodInfoPtr_Interaction_Protected_Virtual_IEnumerator_CharacterInteractionController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 95562, RefRangeEnd = 95563, XrefRangeStart = 95557, XrefRangeEnd = 95562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InteractionBoltZone()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionBoltZone>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InteractionBoltZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 95567, RefRangeEnd = 95570, XrefRangeStart = 95563, XrefRangeEnd = 95567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator __n__0(
    CharacterInteractionController interactionController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactionController)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InteractionBoltZone.NativeMethodInfoPtr___n__0_Private_IEnumerator_CharacterInteractionController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  public static unsafe string InteractionEvent
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(InteractionBoltZone.NativeFieldInfoPtr_InteractionEvent, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InteractionBoltZone.NativeFieldInfoPtr_InteractionEvent, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe InteractionBoltZone.InteractionButtonType buttonType
  {
    get
    {
      return *(InteractionBoltZone.InteractionButtonType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionBoltZone.NativeFieldInfoPtr_buttonType));
    }
    [param: In] set
    {
      *(InteractionBoltZone.InteractionButtonType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionBoltZone.NativeFieldInfoPtr_buttonType)) = value;
    }
  }

  public unsafe InteractionEnterType enterType
  {
    get
    {
      return *(InteractionEnterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionBoltZone.NativeFieldInfoPtr_enterType));
    }
    [param: In] set
    {
      *(InteractionEnterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionBoltZone.NativeFieldInfoPtr_enterType)) = value;
    }
  }

  public unsafe bool manualBreak
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionBoltZone.NativeFieldInfoPtr_manualBreak));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionBoltZone.NativeFieldInfoPtr_manualBreak)) = value;
    }
  }

  public unsafe ScriptMachine flowMachine
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionBoltZone.NativeFieldInfoPtr_flowMachine));
      return num == System.IntPtr.Zero ? (ScriptMachine) null : Il2CppObjectPool.Get<ScriptMachine>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionBoltZone.NativeFieldInfoPtr_flowMachine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool shouldBreak
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionBoltZone.NativeFieldInfoPtr_shouldBreak));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionBoltZone.NativeFieldInfoPtr_shouldBreak)) = value;
    }
  }

  public enum InteractionButtonType
  {
    None,
    Push,
    Hold,
  }

  [ObfuscatedName("SadCatStudios.Triggers.InteractionBoltZone+<Interaction>d__12")]
  public sealed class _Interaction_d__12(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_interactionController;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _Interaction_d__12()
    {
      Il2CppClassPointerStore<InteractionBoltZone._Interaction_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractionBoltZone>.NativeClassPtr, "<Interaction>d__12");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionBoltZone._Interaction_d__12>.NativeClassPtr);
      InteractionBoltZone._Interaction_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionBoltZone._Interaction_d__12>.NativeClassPtr, "<>1__state");
      InteractionBoltZone._Interaction_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionBoltZone._Interaction_d__12>.NativeClassPtr, "<>2__current");
      InteractionBoltZone._Interaction_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionBoltZone._Interaction_d__12>.NativeClassPtr, "<>4__this");
      InteractionBoltZone._Interaction_d__12.NativeFieldInfoPtr_interactionController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionBoltZone._Interaction_d__12>.NativeClassPtr, nameof (interactionController));
      InteractionBoltZone._Interaction_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBoltZone._Interaction_d__12>.NativeClassPtr, 100671636);
      InteractionBoltZone._Interaction_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBoltZone._Interaction_d__12>.NativeClassPtr, 100671637);
      InteractionBoltZone._Interaction_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBoltZone._Interaction_d__12>.NativeClassPtr, 100671638);
      InteractionBoltZone._Interaction_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBoltZone._Interaction_d__12>.NativeClassPtr, 100671639);
      InteractionBoltZone._Interaction_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBoltZone._Interaction_d__12>.NativeClassPtr, 100671640);
      InteractionBoltZone._Interaction_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBoltZone._Interaction_d__12>.NativeClassPtr, 100671641);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Interaction_d__12(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionBoltZone._Interaction_d__12>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InteractionBoltZone._Interaction_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InteractionBoltZone._Interaction_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95491, XrefRangeEnd = 95540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InteractionBoltZone._Interaction_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InteractionBoltZone._Interaction_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95540, XrefRangeEnd = 95545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InteractionBoltZone._Interaction_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InteractionBoltZone._Interaction_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionBoltZone._Interaction_d__12.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionBoltZone._Interaction_d__12.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionBoltZone._Interaction_d__12.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionBoltZone._Interaction_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InteractionBoltZone __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionBoltZone._Interaction_d__12.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (InteractionBoltZone) null : Il2CppObjectPool.Get<InteractionBoltZone>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionBoltZone._Interaction_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterInteractionController interactionController
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionBoltZone._Interaction_d__12.NativeFieldInfoPtr_interactionController));
        return num == System.IntPtr.Zero ? (CharacterInteractionController) null : Il2CppObjectPool.Get<CharacterInteractionController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionBoltZone._Interaction_d__12.NativeFieldInfoPtr_interactionController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
