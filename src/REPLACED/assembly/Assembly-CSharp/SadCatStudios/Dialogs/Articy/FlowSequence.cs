// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.FlowSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Replaced;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

public sealed class FlowSequence : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Handler;
  private static readonly System.IntPtr NativeFieldInfoPtr_DialogueFragment;
  private static readonly System.IntPtr NativeFieldInfoPtr_Element;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FlowHandler_DialogueFragment_FlowElement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_UniTask_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Skip_Public_Void_0;

  static FlowSequence()
  {
    Il2CppClassPointerStore<FlowSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (FlowSequence));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowSequence>.NativeClassPtr);
    FlowSequence.NativeFieldInfoPtr_Handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowSequence>.NativeClassPtr, nameof (Handler));
    FlowSequence.NativeFieldInfoPtr_DialogueFragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowSequence>.NativeClassPtr, nameof (DialogueFragment));
    FlowSequence.NativeFieldInfoPtr_Element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowSequence>.NativeClassPtr, nameof (Element));
    FlowSequence.NativeMethodInfoPtr__ctor_Public_Void_FlowHandler_DialogueFragment_FlowElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowSequence>.NativeClassPtr, 100672918);
    FlowSequence.NativeMethodInfoPtr_Play_Public_UniTask_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowSequence>.NativeClassPtr, 100672919);
    FlowSequence.NativeMethodInfoPtr_Skip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowSequence>.NativeClassPtr, 100672920);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 104847, RefRangeEnd = 104851, XrefRangeStart = 104847, XrefRangeEnd = 104847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlowSequence(
    FlowHandler handler,
    DialogueFragment dialogueFragment,
    FlowElement element)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowSequence>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) handler);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dialogueFragment);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) element);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowSequence.NativeMethodInfoPtr__ctor_Public_Void_FlowHandler_DialogueFragment_FlowElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 104856, RefRangeEnd = 104858, XrefRangeStart = 104851, XrefRangeEnd = 104856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTask Play(CancellationToken cancel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cancel))
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FlowSequence.NativeMethodInfoPtr_Play_Public_UniTask_CancellationToken_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104858, XrefRangeEnd = 104859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Skip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowSequence.NativeMethodInfoPtr_Skip_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public FlowSequence(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public FlowSequence()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowSequence>.NativeClassPtr))
  {
  }

  public unsafe FlowHandler Handler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowSequence.NativeFieldInfoPtr_Handler));
      return num == System.IntPtr.Zero ? (FlowHandler) null : Il2CppObjectPool.Get<FlowHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowSequence.NativeFieldInfoPtr_Handler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DialogueFragment DialogueFragment
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowSequence.NativeFieldInfoPtr_DialogueFragment));
      return num == System.IntPtr.Zero ? (DialogueFragment) null : Il2CppObjectPool.Get<DialogueFragment>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowSequence.NativeFieldInfoPtr_DialogueFragment), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowElement Element
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowSequence.NativeFieldInfoPtr_Element));
      return num == System.IntPtr.Zero ? (FlowElement) null : Il2CppObjectPool.Get<FlowElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowSequence.NativeFieldInfoPtr_Element), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.FlowSequence+<Play>d__4")]
  public sealed class _Play_d__4 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_cancel;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _Play_d__4()
    {
      Il2CppClassPointerStore<FlowSequence._Play_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowSequence>.NativeClassPtr, "<Play>d__4");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowSequence._Play_d__4>.NativeClassPtr);
      FlowSequence._Play_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowSequence._Play_d__4>.NativeClassPtr, "<>1__state");
      FlowSequence._Play_d__4.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowSequence._Play_d__4>.NativeClassPtr, "<>t__builder");
      FlowSequence._Play_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowSequence._Play_d__4>.NativeClassPtr, "<>4__this");
      FlowSequence._Play_d__4.NativeFieldInfoPtr_cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowSequence._Play_d__4>.NativeClassPtr, nameof (cancel));
      FlowSequence._Play_d__4.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowSequence._Play_d__4>.NativeClassPtr, "<>u__1");
      FlowSequence._Play_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowSequence._Play_d__4>.NativeClassPtr, 100672921);
      FlowSequence._Play_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowSequence._Play_d__4>.NativeClassPtr, 100672922);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 104844, RefRangeEnd = 104847, XrefRangeStart = 104838, XrefRangeEnd = 104844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowSequence._Play_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(FlowSequence._Play_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _Play_d__4(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _Play_d__4()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowSequence._Play_d__4>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowSequence._Play_d__4.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowSequence._Play_d__4.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowSequence._Play_d__4.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowSequence._Play_d__4.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public FlowSequence __4__this
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowSequence._Play_d__4.NativeFieldInfoPtr___4__this);
        return new FlowSequence(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FlowSequence>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowSequence._Play_d__4.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FlowSequence>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public CancellationToken cancel
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowSequence._Play_d__4.NativeFieldInfoPtr_cancel);
        return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowSequence._Play_d__4.NativeFieldInfoPtr_cancel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowSequence._Play_d__4.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowSequence._Play_d__4.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
