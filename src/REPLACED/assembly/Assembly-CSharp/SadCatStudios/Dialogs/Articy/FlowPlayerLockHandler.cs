// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.FlowPlayerLockHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using SadCatStudios.Character;
using SadCatStudios.FSM;
using SadCatStudios.MovementPhysics;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

public class FlowPlayerLockHandler(System.IntPtr pointer) : FlowHandler(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_stateController;
  private static readonly System.IntPtr NativeFieldInfoPtr_interactionController;
  private static readonly System.IntPtr NativeFieldInfoPtr_walkController;
  private static readonly System.IntPtr NativeFieldInfoPtr_personPhysics;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_GuidReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForGround_Private_UniTask_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Skip_Public_Virtual_Void_0;

  static FlowPlayerLockHandler()
  {
    Il2CppClassPointerStore<FlowPlayerLockHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (FlowPlayerLockHandler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowPlayerLockHandler>.NativeClassPtr);
    FlowPlayerLockHandler.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayerLockHandler>.NativeClassPtr, nameof (stateController));
    FlowPlayerLockHandler.NativeFieldInfoPtr_interactionController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayerLockHandler>.NativeClassPtr, nameof (interactionController));
    FlowPlayerLockHandler.NativeFieldInfoPtr_walkController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayerLockHandler>.NativeClassPtr, nameof (walkController));
    FlowPlayerLockHandler.NativeFieldInfoPtr_personPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayerLockHandler>.NativeClassPtr, nameof (personPhysics));
    FlowPlayerLockHandler.NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_GuidReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayerLockHandler>.NativeClassPtr, 100672794);
    FlowPlayerLockHandler.NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayerLockHandler>.NativeClassPtr, 100672795);
    FlowPlayerLockHandler.NativeMethodInfoPtr_WaitForGround_Private_UniTask_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayerLockHandler>.NativeClassPtr, 100672796);
    FlowPlayerLockHandler.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayerLockHandler>.NativeClassPtr, 100672797);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103769, XrefRangeEnd = 103782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlowPlayerLockHandler(FlowPlayer player, GuidReference playerReference)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowPlayerLockHandler>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerReference);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowPlayerLockHandler.NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_GuidReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103782, XrefRangeEnd = 103787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe UniTask Play(CancellationToken cancel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cancel))
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowPlayerLockHandler.NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103787, XrefRangeEnd = 103792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTask WaitForGround(CancellationToken cancel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cancel))
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FlowPlayerLockHandler.NativeMethodInfoPtr_WaitForGround_Private_UniTask_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103792, XrefRangeEnd = 103796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Skip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowPlayerLockHandler.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe StateController stateController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler.NativeFieldInfoPtr_stateController));
      return num == System.IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterInteractionController interactionController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler.NativeFieldInfoPtr_interactionController));
      return num == System.IntPtr.Zero ? (CharacterInteractionController) null : Il2CppObjectPool.Get<CharacterInteractionController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler.NativeFieldInfoPtr_interactionController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterWalkController walkController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler.NativeFieldInfoPtr_walkController));
      return num == System.IntPtr.Zero ? (CharacterWalkController) null : Il2CppObjectPool.Get<CharacterWalkController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler.NativeFieldInfoPtr_walkController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PersonPhysics personPhysics
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler.NativeFieldInfoPtr_personPhysics));
      return num == System.IntPtr.Zero ? (PersonPhysics) null : Il2CppObjectPool.Get<PersonPhysics>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler.NativeFieldInfoPtr_personPhysics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.FlowPlayerLockHandler+<Play>d__5")]
  public sealed class _Play_d__5 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_cancel;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _Play_d__5()
    {
      Il2CppClassPointerStore<FlowPlayerLockHandler._Play_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowPlayerLockHandler>.NativeClassPtr, "<Play>d__5");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowPlayerLockHandler._Play_d__5>.NativeClassPtr);
      FlowPlayerLockHandler._Play_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayerLockHandler._Play_d__5>.NativeClassPtr, "<>1__state");
      FlowPlayerLockHandler._Play_d__5.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayerLockHandler._Play_d__5>.NativeClassPtr, "<>t__builder");
      FlowPlayerLockHandler._Play_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayerLockHandler._Play_d__5>.NativeClassPtr, "<>4__this");
      FlowPlayerLockHandler._Play_d__5.NativeFieldInfoPtr_cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayerLockHandler._Play_d__5>.NativeClassPtr, nameof (cancel));
      FlowPlayerLockHandler._Play_d__5.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayerLockHandler._Play_d__5>.NativeClassPtr, "<>u__1");
      FlowPlayerLockHandler._Play_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayerLockHandler._Play_d__5>.NativeClassPtr, 100672798);
      FlowPlayerLockHandler._Play_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayerLockHandler._Play_d__5>.NativeClassPtr, 100672799);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 103680, RefRangeEnd = 103682, XrefRangeStart = 103674, XrefRangeEnd = 103680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowPlayerLockHandler._Play_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(FlowPlayerLockHandler._Play_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _Play_d__5(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _Play_d__5()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowPlayerLockHandler._Play_d__5>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._Play_d__5.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._Play_d__5.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._Play_d__5.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._Play_d__5.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe FlowPlayerLockHandler __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._Play_d__5.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (FlowPlayerLockHandler) null : Il2CppObjectPool.Get<FlowPlayerLockHandler>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._Play_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public CancellationToken cancel
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._Play_d__5.NativeFieldInfoPtr_cancel);
        return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._Play_d__5.NativeFieldInfoPtr_cancel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._Play_d__5.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._Play_d__5.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.FlowPlayerLockHandler+<Skip>d__7")]
  public sealed class _Skip_d__7 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _Skip_d__7()
    {
      Il2CppClassPointerStore<FlowPlayerLockHandler._Skip_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowPlayerLockHandler>.NativeClassPtr, "<Skip>d__7");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowPlayerLockHandler._Skip_d__7>.NativeClassPtr);
      FlowPlayerLockHandler._Skip_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayerLockHandler._Skip_d__7>.NativeClassPtr, "<>1__state");
      FlowPlayerLockHandler._Skip_d__7.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayerLockHandler._Skip_d__7>.NativeClassPtr, "<>t__builder");
      FlowPlayerLockHandler._Skip_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayerLockHandler._Skip_d__7>.NativeClassPtr, "<>4__this");
      FlowPlayerLockHandler._Skip_d__7.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayerLockHandler._Skip_d__7>.NativeClassPtr, "<>u__1");
      FlowPlayerLockHandler._Skip_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayerLockHandler._Skip_d__7>.NativeClassPtr, 100672800);
      FlowPlayerLockHandler._Skip_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayerLockHandler._Skip_d__7>.NativeClassPtr, 100672801);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103682, XrefRangeEnd = 103698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowPlayerLockHandler._Skip_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(FlowPlayerLockHandler._Skip_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _Skip_d__7(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _Skip_d__7()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowPlayerLockHandler._Skip_d__7>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._Skip_d__7.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._Skip_d__7.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._Skip_d__7.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._Skip_d__7.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe FlowPlayerLockHandler __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._Skip_d__7.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (FlowPlayerLockHandler) null : Il2CppObjectPool.Get<FlowPlayerLockHandler>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._Skip_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._Skip_d__7.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._Skip_d__7.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.FlowPlayerLockHandler+<WaitForGround>d__6")]
  public sealed class _WaitForGround_d__6 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_cancel;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _WaitForGround_d__6()
    {
      Il2CppClassPointerStore<FlowPlayerLockHandler._WaitForGround_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowPlayerLockHandler>.NativeClassPtr, "<WaitForGround>d__6");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowPlayerLockHandler._WaitForGround_d__6>.NativeClassPtr);
      FlowPlayerLockHandler._WaitForGround_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayerLockHandler._WaitForGround_d__6>.NativeClassPtr, "<>1__state");
      FlowPlayerLockHandler._WaitForGround_d__6.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayerLockHandler._WaitForGround_d__6>.NativeClassPtr, "<>t__builder");
      FlowPlayerLockHandler._WaitForGround_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayerLockHandler._WaitForGround_d__6>.NativeClassPtr, "<>4__this");
      FlowPlayerLockHandler._WaitForGround_d__6.NativeFieldInfoPtr_cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayerLockHandler._WaitForGround_d__6>.NativeClassPtr, nameof (cancel));
      FlowPlayerLockHandler._WaitForGround_d__6.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPlayerLockHandler._WaitForGround_d__6>.NativeClassPtr, "<>u__1");
      FlowPlayerLockHandler._WaitForGround_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayerLockHandler._WaitForGround_d__6>.NativeClassPtr, 100672802);
      FlowPlayerLockHandler._WaitForGround_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPlayerLockHandler._WaitForGround_d__6>.NativeClassPtr, 100672803);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 103766, RefRangeEnd = 103769, XrefRangeStart = 103698, XrefRangeEnd = 103766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowPlayerLockHandler._WaitForGround_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(FlowPlayerLockHandler._WaitForGround_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _WaitForGround_d__6(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _WaitForGround_d__6()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowPlayerLockHandler._WaitForGround_d__6>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._WaitForGround_d__6.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._WaitForGround_d__6.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._WaitForGround_d__6.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._WaitForGround_d__6.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe FlowPlayerLockHandler __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._WaitForGround_d__6.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (FlowPlayerLockHandler) null : Il2CppObjectPool.Get<FlowPlayerLockHandler>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._WaitForGround_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public CancellationToken cancel
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._WaitForGround_d__6.NativeFieldInfoPtr_cancel);
        return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._WaitForGround_d__6.NativeFieldInfoPtr_cancel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._WaitForGround_d__6.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPlayerLockHandler._WaitForGround_d__6.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
