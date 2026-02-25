// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.FlowTimelineHandler
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
using System.Runtime.InteropServices;
using UnityEngine.Playables;

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

public class FlowTimelineHandler(System.IntPtr pointer) : FlowHandler(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Skip_Public_Virtual_Void_0;

  static FlowTimelineHandler()
  {
    Il2CppClassPointerStore<FlowTimelineHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (FlowTimelineHandler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowTimelineHandler>.NativeClassPtr);
    FlowTimelineHandler.NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowTimelineHandler>.NativeClassPtr, 100672827);
    FlowTimelineHandler.NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowTimelineHandler>.NativeClassPtr, 100672828);
    FlowTimelineHandler.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowTimelineHandler>.NativeClassPtr, 100672829);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlowTimelineHandler(FlowPlayer player)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowTimelineHandler>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowTimelineHandler.NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104216, XrefRangeEnd = 104221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe UniTask Play(CancellationToken cancel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cancel))
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowTimelineHandler.NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104221, XrefRangeEnd = 104238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Skip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowTimelineHandler.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.FlowTimelineHandler+<>c__DisplayClass1_0")]
  public sealed class __c__DisplayClass1_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_playableDirector;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Play_b__0_Internal_Boolean_0;

    static __c__DisplayClass1_0()
    {
      Il2CppClassPointerStore<FlowTimelineHandler.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowTimelineHandler>.NativeClassPtr, "<>c__DisplayClass1_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowTimelineHandler.__c__DisplayClass1_0>.NativeClassPtr);
      FlowTimelineHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_playableDirector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowTimelineHandler.__c__DisplayClass1_0>.NativeClassPtr, nameof (playableDirector));
      FlowTimelineHandler.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowTimelineHandler.__c__DisplayClass1_0>.NativeClassPtr, 100672830);
      FlowTimelineHandler.__c__DisplayClass1_0.NativeMethodInfoPtr__Play_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowTimelineHandler.__c__DisplayClass1_0>.NativeClassPtr, 100672831);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass1_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowTimelineHandler.__c__DisplayClass1_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowTimelineHandler.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104156, XrefRangeEnd = 104157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Play_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowTimelineHandler.__c__DisplayClass1_0.NativeMethodInfoPtr__Play_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe PlayableDirector playableDirector
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowTimelineHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_playableDirector));
        return num == System.IntPtr.Zero ? (PlayableDirector) null : Il2CppObjectPool.Get<PlayableDirector>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowTimelineHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_playableDirector), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.FlowTimelineHandler+<Play>d__1")]
  public sealed class _Play_d__1 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_cancel;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _Play_d__1()
    {
      Il2CppClassPointerStore<FlowTimelineHandler._Play_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowTimelineHandler>.NativeClassPtr, "<Play>d__1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowTimelineHandler._Play_d__1>.NativeClassPtr);
      FlowTimelineHandler._Play_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowTimelineHandler._Play_d__1>.NativeClassPtr, "<>1__state");
      FlowTimelineHandler._Play_d__1.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowTimelineHandler._Play_d__1>.NativeClassPtr, "<>t__builder");
      FlowTimelineHandler._Play_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowTimelineHandler._Play_d__1>.NativeClassPtr, "<>4__this");
      FlowTimelineHandler._Play_d__1.NativeFieldInfoPtr_cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowTimelineHandler._Play_d__1>.NativeClassPtr, nameof (cancel));
      FlowTimelineHandler._Play_d__1.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowTimelineHandler._Play_d__1>.NativeClassPtr, "<>u__1");
      FlowTimelineHandler._Play_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowTimelineHandler._Play_d__1>.NativeClassPtr, 100672832);
      FlowTimelineHandler._Play_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowTimelineHandler._Play_d__1>.NativeClassPtr, 100672833);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 104214, RefRangeEnd = 104216, XrefRangeStart = 104157, XrefRangeEnd = 104214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowTimelineHandler._Play_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(FlowTimelineHandler._Play_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _Play_d__1(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _Play_d__1()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowTimelineHandler._Play_d__1>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowTimelineHandler._Play_d__1.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowTimelineHandler._Play_d__1.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowTimelineHandler._Play_d__1.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowTimelineHandler._Play_d__1.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe FlowTimelineHandler __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowTimelineHandler._Play_d__1.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (FlowTimelineHandler) null : Il2CppObjectPool.Get<FlowTimelineHandler>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowTimelineHandler._Play_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public CancellationToken cancel
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowTimelineHandler._Play_d__1.NativeFieldInfoPtr_cancel);
        return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowTimelineHandler._Play_d__1.NativeFieldInfoPtr_cancel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowTimelineHandler._Play_d__1.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowTimelineHandler._Play_d__1.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
