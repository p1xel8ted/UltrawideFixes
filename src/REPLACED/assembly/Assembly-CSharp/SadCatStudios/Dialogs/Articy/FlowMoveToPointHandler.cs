// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.FlowMoveToPointHandler
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
using SadCatStudios.Animation;
using SadCatStudios.Character;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

public class FlowMoveToPointHandler(System.IntPtr pointer) : FlowHandler(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TurnToActor_Private_Void_MoveToPointElement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Skip_Public_Virtual_Void_0;

  static FlowMoveToPointHandler()
  {
    Il2CppClassPointerStore<FlowMoveToPointHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (FlowMoveToPointHandler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowMoveToPointHandler>.NativeClassPtr);
    FlowMoveToPointHandler.NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowMoveToPointHandler>.NativeClassPtr, 100672777);
    FlowMoveToPointHandler.NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowMoveToPointHandler>.NativeClassPtr, 100672778);
    FlowMoveToPointHandler.NativeMethodInfoPtr_TurnToActor_Private_Void_MoveToPointElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowMoveToPointHandler>.NativeClassPtr, 100672779);
    FlowMoveToPointHandler.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowMoveToPointHandler>.NativeClassPtr, 100672780);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlowMoveToPointHandler(FlowPlayer player)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowMoveToPointHandler>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowMoveToPointHandler.NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103528, XrefRangeEnd = 103533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe UniTask Play(CancellationToken cancel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cancel))
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowMoveToPointHandler.NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 103551, RefRangeEnd = 103554, XrefRangeStart = 103533, XrefRangeEnd = 103551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TurnToActor(MoveToPointElement moveElement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) moveElement)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowMoveToPointHandler.NativeMethodInfoPtr_TurnToActor_Private_Void_MoveToPointElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103554, XrefRangeEnd = 103579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Skip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowMoveToPointHandler.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.FlowMoveToPointHandler+<>c__DisplayClass1_0")]
  public sealed class __c__DisplayClass1_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_animationController;
    private static readonly System.IntPtr NativeFieldInfoPtr_moveOutClip;
    private static readonly System.IntPtr NativeFieldInfoPtr_cancel;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_moveElement;
    private static readonly System.IntPtr NativeFieldInfoPtr_finishedPromise;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_UniTaskVoid_PDM_0;

    static __c__DisplayClass1_0()
    {
      Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowMoveToPointHandler>.NativeClassPtr, "<>c__DisplayClass1_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0>.NativeClassPtr);
      FlowMoveToPointHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0>.NativeClassPtr, nameof (animationController));
      FlowMoveToPointHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_moveOutClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0>.NativeClassPtr, nameof (moveOutClip));
      FlowMoveToPointHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0>.NativeClassPtr, nameof (cancel));
      FlowMoveToPointHandler.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
      FlowMoveToPointHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_moveElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0>.NativeClassPtr, nameof (moveElement));
      FlowMoveToPointHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_finishedPromise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0>.NativeClassPtr, nameof (finishedPromise));
      FlowMoveToPointHandler.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0>.NativeClassPtr, 100672781);
      FlowMoveToPointHandler.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0>.NativeClassPtr, 100672782);
      FlowMoveToPointHandler.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_UniTaskVoid_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0>.NativeClassPtr, 100672783);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass1_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowMoveToPointHandler.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103430, XrefRangeEnd = 103434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Method_Internal_Void_PDM_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowMoveToPointHandler.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103434, XrefRangeEnd = 103437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UniTaskVoid Method_Internal_UniTaskVoid_PDM_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowMoveToPointHandler.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_UniTaskVoid_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(UniTaskVoid*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterAnimationController animationController
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_animationController));
        return num == System.IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MeshClip moveOutClip
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_moveOutClip));
        return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_moveOutClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public CancellationToken cancel
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_cancel);
        return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_cancel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe FlowMoveToPointHandler __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (FlowMoveToPointHandler) null : Il2CppObjectPool.Get<FlowMoveToPointHandler>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MoveToPointElement moveElement
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_moveElement));
        return num == System.IntPtr.Zero ? (MoveToPointElement) null : Il2CppObjectPool.Get<MoveToPointElement>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_moveElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UniTaskCompletionSource finishedPromise
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_finishedPromise));
        return num == System.IntPtr.Zero ? (UniTaskCompletionSource) null : Il2CppObjectPool.Get<UniTaskCompletionSource>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_finishedPromise), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("SadCatStudios.Dialogs.Articy.FlowMoveToPointHandler+<>c__DisplayClass1_0+<<Play>g__WaitForArrival|1>d")]
    public sealed class ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique : 
      Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

      static ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique()
      {
        Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0>.NativeClassPtr, "<<Play>g__WaitForArrival|1>d");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr);
        FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>1__state");
        FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>t__builder");
        FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>4__this");
        FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>u__1");
        FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, 100672784);
        FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, 100672785);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103394, XrefRangeEnd = 103430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
        IL2CPP.il2cpp_runtime_invoke(FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique()
        : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr))
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public AsyncUniTaskVoidMethodBuilder __t__builder
      {
        get
        {
          System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___t__builder);
          return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, num));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe FlowMoveToPointHandler.__c__DisplayClass1_0 __4__this
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___4__this));
          return num == System.IntPtr.Zero ? (FlowMoveToPointHandler.__c__DisplayClass1_0) null : Il2CppObjectPool.Get<FlowMoveToPointHandler.__c__DisplayClass1_0>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public UniTask.Awaiter __u__1
      {
        get
        {
          System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___u__1);
          return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.FlowMoveToPointHandler+<Play>d__1")]
  public sealed class _Play_d__1 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_cancel;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___8__1;
    private static readonly System.IntPtr NativeFieldInfoPtr__movingActor_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__cutsceneMoveController_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__idleController_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__moveClip_5__5;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _Play_d__1()
    {
      Il2CppClassPointerStore<FlowMoveToPointHandler._Play_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowMoveToPointHandler>.NativeClassPtr, "<Play>d__1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowMoveToPointHandler._Play_d__1>.NativeClassPtr);
      FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler._Play_d__1>.NativeClassPtr, "<>1__state");
      FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler._Play_d__1>.NativeClassPtr, "<>t__builder");
      FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr_cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler._Play_d__1>.NativeClassPtr, nameof (cancel));
      FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler._Play_d__1>.NativeClassPtr, "<>4__this");
      FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler._Play_d__1>.NativeClassPtr, "<>8__1");
      FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr__movingActor_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler._Play_d__1>.NativeClassPtr, "<movingActor>5__2");
      FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr__cutsceneMoveController_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler._Play_d__1>.NativeClassPtr, "<cutsceneMoveController>5__3");
      FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr__idleController_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler._Play_d__1>.NativeClassPtr, "<idleController>5__4");
      FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr__moveClip_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler._Play_d__1>.NativeClassPtr, "<moveClip>5__5");
      FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowMoveToPointHandler._Play_d__1>.NativeClassPtr, "<>u__1");
      FlowMoveToPointHandler._Play_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowMoveToPointHandler._Play_d__1>.NativeClassPtr, 100672786);
      FlowMoveToPointHandler._Play_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowMoveToPointHandler._Play_d__1>.NativeClassPtr, 100672787);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 103525, RefRangeEnd = 103528, XrefRangeStart = 103437, XrefRangeEnd = 103525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowMoveToPointHandler._Play_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(FlowMoveToPointHandler._Play_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _Play_d__1(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _Play_d__1()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowMoveToPointHandler._Play_d__1>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public CancellationToken cancel
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr_cancel);
        return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr_cancel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe FlowMoveToPointHandler __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (FlowMoveToPointHandler) null : Il2CppObjectPool.Get<FlowMoveToPointHandler>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FlowMoveToPointHandler.__c__DisplayClass1_0 __8__1
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr___8__1));
        return num == System.IntPtr.Zero ? (FlowMoveToPointHandler.__c__DisplayClass1_0) null : Il2CppObjectPool.Get<FlowMoveToPointHandler.__c__DisplayClass1_0>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GuidReference _movingActor_5__2
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr__movingActor_5__2));
        return num == System.IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr__movingActor_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterCutsceneMoveController _cutsceneMoveController_5__3
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr__cutsceneMoveController_5__3));
        return num == System.IntPtr.Zero ? (CharacterCutsceneMoveController) null : Il2CppObjectPool.Get<CharacterCutsceneMoveController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr__cutsceneMoveController_5__3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterIdleController _idleController_5__4
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr__idleController_5__4));
        return num == System.IntPtr.Zero ? (CharacterIdleController) null : Il2CppObjectPool.Get<CharacterIdleController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr__idleController_5__4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MeshClip _moveClip_5__5
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr__moveClip_5__5));
        return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr__moveClip_5__5), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowMoveToPointHandler._Play_d__1.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
