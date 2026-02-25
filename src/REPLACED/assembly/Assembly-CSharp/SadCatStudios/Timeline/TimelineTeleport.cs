// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.TimelineTeleport
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
using SadCatStudios.Character;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
namespace SadCatStudios.Timeline;

public class TimelineTeleport(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_portalLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_portal;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerReference;
  private static readonly System.IntPtr NativeFieldInfoPtr_binder;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TeleportAfterCutscene_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TimelineTeleport()
  {
    Il2CppClassPointerStore<TimelineTeleport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (TimelineTeleport));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineTeleport>.NativeClassPtr);
    TimelineTeleport.NativeFieldInfoPtr_portalLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineTeleport>.NativeClassPtr, nameof (portalLabel));
    TimelineTeleport.NativeFieldInfoPtr_portal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineTeleport>.NativeClassPtr, nameof (portal));
    TimelineTeleport.NativeFieldInfoPtr_playerReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineTeleport>.NativeClassPtr, nameof (playerReference));
    TimelineTeleport.NativeFieldInfoPtr_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineTeleport>.NativeClassPtr, nameof (binder));
    TimelineTeleport.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineTeleport>.NativeClassPtr, 100670881);
    TimelineTeleport.NativeMethodInfoPtr_TeleportAfterCutscene_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineTeleport>.NativeClassPtr, 100670882);
    TimelineTeleport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineTeleport>.NativeClassPtr, 100670883);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89282, XrefRangeEnd = 89285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineTeleport.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89285, XrefRangeEnd = 89309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TeleportAfterCutscene()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineTeleport.NativeMethodInfoPtr_TeleportAfterCutscene_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TimelineTeleport()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimelineTeleport>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineTeleport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AssetLabelReference portalLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.NativeFieldInfoPtr_portalLabel));
      return num == System.IntPtr.Zero ? (AssetLabelReference) null : Il2CppObjectPool.Get<AssetLabelReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.NativeFieldInfoPtr_portalLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GuidReference portal
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.NativeFieldInfoPtr_portal));
      return num == System.IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.NativeFieldInfoPtr_portal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GuidReference playerReference
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.NativeFieldInfoPtr_playerReference));
      return num == System.IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.NativeFieldInfoPtr_playerReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TimelineBinder binder
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.NativeFieldInfoPtr_binder));
      return num == System.IntPtr.Zero ? (TimelineBinder) null : Il2CppObjectPool.Get<TimelineBinder>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.NativeFieldInfoPtr_binder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Timeline.TimelineTeleport+<>c__DisplayClass5_0")]
  public sealed class __c__DisplayClass5_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_interactionController;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TeleportAfterCutscene_b__0_Internal_UniTask_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TeleportAfterCutscene_b__1_Internal_Void_0;

    static __c__DisplayClass5_0()
    {
      Il2CppClassPointerStore<TimelineTeleport.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimelineTeleport>.NativeClassPtr, "<>c__DisplayClass5_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineTeleport.__c__DisplayClass5_0>.NativeClassPtr);
      TimelineTeleport.__c__DisplayClass5_0.NativeFieldInfoPtr_interactionController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineTeleport.__c__DisplayClass5_0>.NativeClassPtr, nameof (interactionController));
      TimelineTeleport.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineTeleport.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
      TimelineTeleport.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineTeleport.__c__DisplayClass5_0>.NativeClassPtr, 100670884);
      TimelineTeleport.__c__DisplayClass5_0.NativeMethodInfoPtr__TeleportAfterCutscene_b__0_Internal_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineTeleport.__c__DisplayClass5_0>.NativeClassPtr, 100670885);
      TimelineTeleport.__c__DisplayClass5_0.NativeMethodInfoPtr__TeleportAfterCutscene_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineTeleport.__c__DisplayClass5_0>.NativeClassPtr, 100670886);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass5_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimelineTeleport.__c__DisplayClass5_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TimelineTeleport.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89251, XrefRangeEnd = 89267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UniTask _TeleportAfterCutscene_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TimelineTeleport.__c__DisplayClass5_0.NativeMethodInfoPtr__TeleportAfterCutscene_b__0_Internal_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new UniTask(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89267, XrefRangeEnd = 89282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _TeleportAfterCutscene_b__1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TimelineTeleport.__c__DisplayClass5_0.NativeMethodInfoPtr__TeleportAfterCutscene_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe CharacterInteractionController interactionController
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.__c__DisplayClass5_0.NativeFieldInfoPtr_interactionController));
        return num == System.IntPtr.Zero ? (CharacterInteractionController) null : Il2CppObjectPool.Get<CharacterInteractionController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.__c__DisplayClass5_0.NativeFieldInfoPtr_interactionController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TimelineTeleport __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (TimelineTeleport) null : Il2CppObjectPool.Get<TimelineTeleport>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("SadCatStudios.Timeline.TimelineTeleport+<>c__DisplayClass5_0+<<TeleportAfterCutscene>b__0>d")]
    public sealed class __TeleportAfterCutscene_b__0_d : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
      private static readonly System.IntPtr NativeFieldInfoPtr___u__2;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

      static __TeleportAfterCutscene_b__0_d()
      {
        Il2CppClassPointerStore<TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimelineTeleport.__c__DisplayClass5_0>.NativeClassPtr, "<<TeleportAfterCutscene>b__0>d");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d>.NativeClassPtr);
        TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d>.NativeClassPtr, "<>1__state");
        TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d>.NativeClassPtr, "<>t__builder");
        TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d>.NativeClassPtr, "<>4__this");
        TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d>.NativeClassPtr, "<>u__1");
        TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d>.NativeClassPtr, "<>u__2");
        TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d>.NativeClassPtr, 100670887);
        TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d>.NativeClassPtr, 100670888);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 89249, RefRangeEnd = 89251, XrefRangeStart = 89216, XrefRangeEnd = 89249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
        IL2CPP.il2cpp_runtime_invoke(TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public __TeleportAfterCutscene_b__0_d(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __TeleportAfterCutscene_b__0_d()
        : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d>.NativeClassPtr))
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public AsyncUniTaskMethodBuilder __t__builder
      {
        get
        {
          System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d.NativeFieldInfoPtr___t__builder);
          return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe TimelineTeleport.__c__DisplayClass5_0 __4__this
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d.NativeFieldInfoPtr___4__this));
          return num == System.IntPtr.Zero ? (TimelineTeleport.__c__DisplayClass5_0) null : Il2CppObjectPool.Get<TimelineTeleport.__c__DisplayClass5_0>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public UniTask.Awaiter __u__1
      {
        get
        {
          System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d.NativeFieldInfoPtr___u__1);
          return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public Awaitable.Awaiter __u__2
      {
        get
        {
          System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d.NativeFieldInfoPtr___u__2);
          return new Awaitable.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Awaitable.Awaiter>.NativeClassPtr, num));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineTeleport.__c__DisplayClass5_0.__TeleportAfterCutscene_b__0_d.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Awaitable.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }
}
