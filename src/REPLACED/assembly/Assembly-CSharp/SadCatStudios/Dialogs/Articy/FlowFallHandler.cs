// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.FlowFallHandler
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

public class FlowFallHandler(System.IntPtr pointer) : FlowHandler(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Skip_Public_Virtual_Void_0;

  static FlowFallHandler()
  {
    Il2CppClassPointerStore<FlowFallHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (FlowFallHandler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowFallHandler>.NativeClassPtr);
    FlowFallHandler.NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowFallHandler>.NativeClassPtr, 100672745);
    FlowFallHandler.NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowFallHandler>.NativeClassPtr, 100672746);
    FlowFallHandler.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowFallHandler>.NativeClassPtr, 100672747);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlowFallHandler(FlowPlayer player)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowFallHandler>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowFallHandler.NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103266, XrefRangeEnd = 103271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe UniTask Play(CancellationToken cancel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cancel))
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowFallHandler.NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103271, XrefRangeEnd = 103290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Skip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowFallHandler.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.FlowFallHandler+<>c__DisplayClass1_0")]
  public sealed class __c__DisplayClass1_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_fallElement;
    private static readonly System.IntPtr NativeFieldInfoPtr_fallPromise;
    private static readonly System.IntPtr NativeFieldInfoPtr_animationController;
    private static readonly System.IntPtr NativeFieldInfoPtr_landClip;
    private static readonly System.IntPtr NativeFieldInfoPtr_cancel;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_UniTaskVoid_PDM_0;

    static __c__DisplayClass1_0()
    {
      Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowFallHandler>.NativeClassPtr, "<>c__DisplayClass1_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0>.NativeClassPtr);
      FlowFallHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_fallElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0>.NativeClassPtr, nameof (fallElement));
      FlowFallHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_fallPromise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0>.NativeClassPtr, nameof (fallPromise));
      FlowFallHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0>.NativeClassPtr, nameof (animationController));
      FlowFallHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_landClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0>.NativeClassPtr, nameof (landClip));
      FlowFallHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0>.NativeClassPtr, nameof (cancel));
      FlowFallHandler.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0>.NativeClassPtr, 100672748);
      FlowFallHandler.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0>.NativeClassPtr, 100672749);
      FlowFallHandler.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_UniTaskVoid_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0>.NativeClassPtr, 100672750);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass1_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowFallHandler.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103241, XrefRangeEnd = 103246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Method_Internal_Void_PDM_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowFallHandler.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103246, XrefRangeEnd = 103249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UniTaskVoid Method_Internal_UniTaskVoid_PDM_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowFallHandler.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_UniTaskVoid_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(UniTaskVoid*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe FallElement fallElement
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_fallElement));
        return num == System.IntPtr.Zero ? (FallElement) null : Il2CppObjectPool.Get<FallElement>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_fallElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UniTaskCompletionSource fallPromise
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_fallPromise));
        return num == System.IntPtr.Zero ? (UniTaskCompletionSource) null : Il2CppObjectPool.Get<UniTaskCompletionSource>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_fallPromise), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterAnimationController animationController
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_animationController));
        return num == System.IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MeshClip landClip
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_landClip));
        return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_landClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public CancellationToken cancel
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_cancel);
        return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_cancel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [ObfuscatedName("SadCatStudios.Dialogs.Articy.FlowFallHandler+<>c__DisplayClass1_0+<<Play>g__WaitForArrival|1>d")]
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
        Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0>.NativeClassPtr, "<<Play>g__WaitForArrival|1>d");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr);
        FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>1__state");
        FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>t__builder");
        FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>4__this");
        FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>u__1");
        FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, 100672751);
        FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, 100672752);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103211, XrefRangeEnd = 103241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
        IL2CPP.il2cpp_runtime_invoke(FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique()
        : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr))
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public AsyncUniTaskVoidMethodBuilder __t__builder
      {
        get
        {
          System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___t__builder);
          return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, num));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe FlowFallHandler.__c__DisplayClass1_0 __4__this
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___4__this));
          return num == System.IntPtr.Zero ? (FlowFallHandler.__c__DisplayClass1_0) null : Il2CppObjectPool.Get<FlowFallHandler.__c__DisplayClass1_0>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public UniTask.Awaiter __u__1
      {
        get
        {
          System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___u__1);
          return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler.__c__DisplayClass1_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.FlowFallHandler+<Play>d__1")]
  public sealed class _Play_d__1 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_cancel;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _Play_d__1()
    {
      Il2CppClassPointerStore<FlowFallHandler._Play_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowFallHandler>.NativeClassPtr, "<Play>d__1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowFallHandler._Play_d__1>.NativeClassPtr);
      FlowFallHandler._Play_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowFallHandler._Play_d__1>.NativeClassPtr, "<>1__state");
      FlowFallHandler._Play_d__1.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowFallHandler._Play_d__1>.NativeClassPtr, "<>t__builder");
      FlowFallHandler._Play_d__1.NativeFieldInfoPtr_cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowFallHandler._Play_d__1>.NativeClassPtr, nameof (cancel));
      FlowFallHandler._Play_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowFallHandler._Play_d__1>.NativeClassPtr, "<>4__this");
      FlowFallHandler._Play_d__1.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowFallHandler._Play_d__1>.NativeClassPtr, "<>u__1");
      FlowFallHandler._Play_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowFallHandler._Play_d__1>.NativeClassPtr, 100672753);
      FlowFallHandler._Play_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowFallHandler._Play_d__1>.NativeClassPtr, 100672754);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 103263, RefRangeEnd = 103266, XrefRangeStart = 103249, XrefRangeEnd = 103263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowFallHandler._Play_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(FlowFallHandler._Play_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _Play_d__1(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _Play_d__1()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowFallHandler._Play_d__1>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler._Play_d__1.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler._Play_d__1.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler._Play_d__1.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler._Play_d__1.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public CancellationToken cancel
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler._Play_d__1.NativeFieldInfoPtr_cancel);
        return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler._Play_d__1.NativeFieldInfoPtr_cancel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe FlowFallHandler __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler._Play_d__1.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (FlowFallHandler) null : Il2CppObjectPool.Get<FlowFallHandler>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler._Play_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler._Play_d__1.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowFallHandler._Play_d__1.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
