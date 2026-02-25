// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.AreaAttackAnnouncer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using SadCatStudios.Character;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class AreaAttackAnnouncer(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_indicator;
  private static readonly System.IntPtr NativeFieldInfoPtr_animationController;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendAnnounce_Public_Virtual_Final_New_Void_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndAnnounce_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HideAfterStartup_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AreaAttackAnnouncer()
  {
    Il2CppClassPointerStore<AreaAttackAnnouncer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (AreaAttackAnnouncer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AreaAttackAnnouncer>.NativeClassPtr);
    AreaAttackAnnouncer.NativeFieldInfoPtr_indicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaAttackAnnouncer>.NativeClassPtr, nameof (indicator));
    AreaAttackAnnouncer.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaAttackAnnouncer>.NativeClassPtr, nameof (animationController));
    AreaAttackAnnouncer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaAttackAnnouncer>.NativeClassPtr, 100677046);
    AreaAttackAnnouncer.NativeMethodInfoPtr_SendAnnounce_Public_Virtual_Final_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaAttackAnnouncer>.NativeClassPtr, 100677047);
    AreaAttackAnnouncer.NativeMethodInfoPtr_EndAnnounce_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaAttackAnnouncer>.NativeClassPtr, 100677048);
    AreaAttackAnnouncer.NativeMethodInfoPtr_HideAfterStartup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaAttackAnnouncer>.NativeClassPtr, 100677049);
    AreaAttackAnnouncer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaAttackAnnouncer>.NativeClassPtr, 100677050);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127933, XrefRangeEnd = 127936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AreaAttackAnnouncer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127936, XrefRangeEnd = 127943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SendAnnounce(AttackObject attack)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AreaAttackAnnouncer.NativeMethodInfoPtr_SendAnnounce_Public_Virtual_Final_New_Void_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127943, XrefRangeEnd = 127945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EndAnnounce()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AreaAttackAnnouncer.NativeMethodInfoPtr_EndAnnounce_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127945, XrefRangeEnd = 127949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HideAfterStartup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AreaAttackAnnouncer.NativeMethodInfoPtr_HideAfterStartup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AreaAttackAnnouncer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AreaAttackAnnouncer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AreaAttackAnnouncer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GameObject indicator
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaAttackAnnouncer.NativeFieldInfoPtr_indicator));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AreaAttackAnnouncer.NativeFieldInfoPtr_indicator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaAttackAnnouncer.NativeFieldInfoPtr_animationController));
      return num == System.IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AreaAttackAnnouncer.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.AreaAttackAnnouncer+<HideAfterStartup>d__5")]
  public sealed class _HideAfterStartup_d__5 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _HideAfterStartup_d__5()
    {
      Il2CppClassPointerStore<AreaAttackAnnouncer._HideAfterStartup_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AreaAttackAnnouncer>.NativeClassPtr, "<HideAfterStartup>d__5");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AreaAttackAnnouncer._HideAfterStartup_d__5>.NativeClassPtr);
      AreaAttackAnnouncer._HideAfterStartup_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaAttackAnnouncer._HideAfterStartup_d__5>.NativeClassPtr, "<>1__state");
      AreaAttackAnnouncer._HideAfterStartup_d__5.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaAttackAnnouncer._HideAfterStartup_d__5>.NativeClassPtr, "<>t__builder");
      AreaAttackAnnouncer._HideAfterStartup_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaAttackAnnouncer._HideAfterStartup_d__5>.NativeClassPtr, "<>4__this");
      AreaAttackAnnouncer._HideAfterStartup_d__5.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaAttackAnnouncer._HideAfterStartup_d__5>.NativeClassPtr, "<>u__1");
      AreaAttackAnnouncer._HideAfterStartup_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaAttackAnnouncer._HideAfterStartup_d__5>.NativeClassPtr, 100677051);
      AreaAttackAnnouncer._HideAfterStartup_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaAttackAnnouncer._HideAfterStartup_d__5>.NativeClassPtr, 100677052);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127907, XrefRangeEnd = 127933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AreaAttackAnnouncer._HideAfterStartup_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(AreaAttackAnnouncer._HideAfterStartup_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _HideAfterStartup_d__5(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _HideAfterStartup_d__5()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AreaAttackAnnouncer._HideAfterStartup_d__5>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaAttackAnnouncer._HideAfterStartup_d__5.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaAttackAnnouncer._HideAfterStartup_d__5.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaAttackAnnouncer._HideAfterStartup_d__5.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaAttackAnnouncer._HideAfterStartup_d__5.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe AreaAttackAnnouncer __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaAttackAnnouncer._HideAfterStartup_d__5.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (AreaAttackAnnouncer) null : Il2CppObjectPool.Get<AreaAttackAnnouncer>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AreaAttackAnnouncer._HideAfterStartup_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Cysharp.Threading.Tasks.YieldAwaitable.Awaiter __u__1
    {
      get
      {
        return *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaAttackAnnouncer._HideAfterStartup_d__5.NativeFieldInfoPtr___u__1));
      }
      [param: In] set
      {
        *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaAttackAnnouncer._HideAfterStartup_d__5.NativeFieldInfoPtr___u__1)) = value;
      }
    }
  }
}
