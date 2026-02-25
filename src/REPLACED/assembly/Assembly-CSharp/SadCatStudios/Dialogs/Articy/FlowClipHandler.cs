// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.FlowClipHandler
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

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

public class FlowClipHandler(System.IntPtr pointer) : FlowHandler(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Skip_Public_Virtual_Void_0;

  static FlowClipHandler()
  {
    Il2CppClassPointerStore<FlowClipHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (FlowClipHandler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowClipHandler>.NativeClassPtr);
    FlowClipHandler.NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowClipHandler>.NativeClassPtr, 100672737);
    FlowClipHandler.NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowClipHandler>.NativeClassPtr, 100672738);
    FlowClipHandler.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowClipHandler>.NativeClassPtr, 100672739);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlowClipHandler(FlowPlayer player)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowClipHandler>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowClipHandler.NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103166, XrefRangeEnd = 103171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe UniTask Play(CancellationToken cancel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cancel))
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowClipHandler.NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103171, XrefRangeEnd = 103178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Skip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowClipHandler.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.FlowClipHandler+<Play>d__1")]
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
      Il2CppClassPointerStore<FlowClipHandler._Play_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowClipHandler>.NativeClassPtr, "<Play>d__1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowClipHandler._Play_d__1>.NativeClassPtr);
      FlowClipHandler._Play_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowClipHandler._Play_d__1>.NativeClassPtr, "<>1__state");
      FlowClipHandler._Play_d__1.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowClipHandler._Play_d__1>.NativeClassPtr, "<>t__builder");
      FlowClipHandler._Play_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowClipHandler._Play_d__1>.NativeClassPtr, "<>4__this");
      FlowClipHandler._Play_d__1.NativeFieldInfoPtr_cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowClipHandler._Play_d__1>.NativeClassPtr, nameof (cancel));
      FlowClipHandler._Play_d__1.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowClipHandler._Play_d__1>.NativeClassPtr, "<>u__1");
      FlowClipHandler._Play_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowClipHandler._Play_d__1>.NativeClassPtr, 100672740);
      FlowClipHandler._Play_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowClipHandler._Play_d__1>.NativeClassPtr, 100672741);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 103163, RefRangeEnd = 103166, XrefRangeStart = 103153, XrefRangeEnd = 103163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowClipHandler._Play_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(FlowClipHandler._Play_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _Play_d__1(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _Play_d__1()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowClipHandler._Play_d__1>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowClipHandler._Play_d__1.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowClipHandler._Play_d__1.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowClipHandler._Play_d__1.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowClipHandler._Play_d__1.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe FlowClipHandler __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowClipHandler._Play_d__1.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (FlowClipHandler) null : Il2CppObjectPool.Get<FlowClipHandler>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowClipHandler._Play_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public CancellationToken cancel
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowClipHandler._Play_d__1.NativeFieldInfoPtr_cancel);
        return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowClipHandler._Play_d__1.NativeFieldInfoPtr_cancel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowClipHandler._Play_d__1.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowClipHandler._Play_d__1.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
