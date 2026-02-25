// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.FlowPortalHandler
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
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

public class FlowPortalHandler(System.IntPtr pointer) : FlowHandler(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_interactionController;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_GuidReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Skip_Public_Virtual_Void_0;

  static FlowPortalHandler()
  {
    Il2CppClassPointerStore<FlowPortalHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (FlowPortalHandler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowPortalHandler>.NativeClassPtr);
    FlowPortalHandler.NativeFieldInfoPtr_interactionController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPortalHandler>.NativeClassPtr, nameof (interactionController));
    FlowPortalHandler.NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_GuidReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPortalHandler>.NativeClassPtr, 100672804);
    FlowPortalHandler.NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPortalHandler>.NativeClassPtr, 100672805);
    FlowPortalHandler.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPortalHandler>.NativeClassPtr, 100672806);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103838, XrefRangeEnd = 103842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlowPortalHandler(FlowPlayer player, GuidReference playerReference)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowPortalHandler>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerReference);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowPortalHandler.NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_GuidReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103842, XrefRangeEnd = 103859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe UniTask Play(CancellationToken cancel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cancel))
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowPortalHandler.NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(0)]
  public override unsafe void Skip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowPortalHandler.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CharacterInteractionController interactionController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.NativeFieldInfoPtr_interactionController));
      return num == System.IntPtr.Zero ? (CharacterInteractionController) null : Il2CppObjectPool.Get<CharacterInteractionController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.NativeFieldInfoPtr_interactionController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.FlowPortalHandler+<>c__DisplayClass2_0")]
  public sealed class __c__DisplayClass2_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_portalLabel;
    private static readonly System.IntPtr NativeFieldInfoPtr_portal;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Play_b__0_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Play_b__1_Internal_UniTask_0;

    static __c__DisplayClass2_0()
    {
      Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowPortalHandler>.NativeClassPtr, "<>c__DisplayClass2_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0>.NativeClassPtr);
      FlowPortalHandler.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
      FlowPortalHandler.__c__DisplayClass2_0.NativeFieldInfoPtr_portalLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0>.NativeClassPtr, nameof (portalLabel));
      FlowPortalHandler.__c__DisplayClass2_0.NativeFieldInfoPtr_portal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0>.NativeClassPtr, nameof (portal));
      FlowPortalHandler.__c__DisplayClass2_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0>.NativeClassPtr, "<>9__1");
      FlowPortalHandler.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0>.NativeClassPtr, 100672807);
      FlowPortalHandler.__c__DisplayClass2_0.NativeMethodInfoPtr__Play_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0>.NativeClassPtr, 100672808);
      FlowPortalHandler.__c__DisplayClass2_0.NativeMethodInfoPtr__Play_b__1_Internal_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0>.NativeClassPtr, 100672809);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass2_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowPortalHandler.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103822, XrefRangeEnd = 103833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Play_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowPortalHandler.__c__DisplayClass2_0.NativeMethodInfoPtr__Play_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103833, XrefRangeEnd = 103838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UniTask _Play_b__1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FlowPortalHandler.__c__DisplayClass2_0.NativeMethodInfoPtr__Play_b__1_Internal_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new UniTask(pointer);
    }

    public unsafe FlowPortalHandler __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (FlowPortalHandler) null : Il2CppObjectPool.Get<FlowPortalHandler>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AssetLabelReference portalLabel
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.__c__DisplayClass2_0.NativeFieldInfoPtr_portalLabel));
        return num == System.IntPtr.Zero ? (AssetLabelReference) null : Il2CppObjectPool.Get<AssetLabelReference>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.__c__DisplayClass2_0.NativeFieldInfoPtr_portalLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GuidReference portal
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.__c__DisplayClass2_0.NativeFieldInfoPtr_portal));
        return num == System.IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.__c__DisplayClass2_0.NativeFieldInfoPtr_portal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Func<UniTask> __9__1
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.__c__DisplayClass2_0.NativeFieldInfoPtr___9__1));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Func<UniTask>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<UniTask>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.__c__DisplayClass2_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("SadCatStudios.Dialogs.Articy.FlowPortalHandler+<>c__DisplayClass2_0+<<Play>b__1>d")]
    public sealed class __Play_b__1_d : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
      private static readonly System.IntPtr NativeFieldInfoPtr___u__2;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

      static __Play_b__1_d()
      {
        Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0>.NativeClassPtr, "<<Play>b__1>d");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d>.NativeClassPtr);
        FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d>.NativeClassPtr, "<>1__state");
        FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d>.NativeClassPtr, "<>t__builder");
        FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d>.NativeClassPtr, "<>4__this");
        FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d>.NativeClassPtr, "<>u__1");
        FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d>.NativeClassPtr, "<>u__2");
        FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d>.NativeClassPtr, 100672810);
        FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d>.NativeClassPtr, 100672811);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 103820, RefRangeEnd = 103822, XrefRangeStart = 103796, XrefRangeEnd = 103820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
        IL2CPP.il2cpp_runtime_invoke(FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public __Play_b__1_d(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __Play_b__1_d()
        : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d>.NativeClassPtr))
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public AsyncUniTaskMethodBuilder __t__builder
      {
        get
        {
          System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d.NativeFieldInfoPtr___t__builder);
          return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe FlowPortalHandler.__c__DisplayClass2_0 __4__this
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d.NativeFieldInfoPtr___4__this));
          return num == System.IntPtr.Zero ? (FlowPortalHandler.__c__DisplayClass2_0) null : Il2CppObjectPool.Get<FlowPortalHandler.__c__DisplayClass2_0>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public UniTask.Awaiter __u__1
      {
        get
        {
          System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d.NativeFieldInfoPtr___u__1);
          return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public Awaitable.Awaiter __u__2
      {
        get
        {
          System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d.NativeFieldInfoPtr___u__2);
          return new Awaitable.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Awaitable.Awaiter>.NativeClassPtr, num));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowPortalHandler.__c__DisplayClass2_0.__Play_b__1_d.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Awaitable.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }
}
