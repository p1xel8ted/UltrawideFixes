// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Effects.EmissionBlinker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Effects;

public class EmissionBlinker(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_material;
  private static readonly System.IntPtr NativeFieldInfoPtr_blinks;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BlinkCycle_Private_UniTaskVoid_BlinkData_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static EmissionBlinker()
  {
    Il2CppClassPointerStore<EmissionBlinker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Effects", nameof (EmissionBlinker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmissionBlinker>.NativeClassPtr);
    EmissionBlinker.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmissionBlinker>.NativeClassPtr, nameof (material));
    EmissionBlinker.NativeFieldInfoPtr_blinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmissionBlinker>.NativeClassPtr, nameof (blinks));
    EmissionBlinker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmissionBlinker>.NativeClassPtr, 100675759);
    EmissionBlinker.NativeMethodInfoPtr_BlinkCycle_Private_UniTaskVoid_BlinkData_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmissionBlinker>.NativeClassPtr, 100675760 /*0x060030B0*/);
    EmissionBlinker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmissionBlinker>.NativeClassPtr, 100675761);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119348, XrefRangeEnd = 119354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EmissionBlinker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119354, XrefRangeEnd = 119357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTaskVoid BlinkCycle(
    EmissionBlinker.BlinkData blinkData,
    CancellationToken cancellationToken)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) blinkData));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cancellationToken));
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EmissionBlinker.NativeMethodInfoPtr_BlinkCycle_Private_UniTaskVoid_BlinkData_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(UniTaskVoid*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EmissionBlinker()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmissionBlinker>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EmissionBlinker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Material material
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker.NativeFieldInfoPtr_material));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<EmissionBlinker.BlinkData> blinks
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker.NativeFieldInfoPtr_blinks));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<EmissionBlinker.BlinkData>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<EmissionBlinker.BlinkData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker.NativeFieldInfoPtr_blinks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class BlinkData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Id;
    private static readonly System.IntPtr NativeFieldInfoPtr_InitialDelay;
    private static readonly System.IntPtr NativeFieldInfoPtr_FirstDelay;
    private static readonly System.IntPtr NativeFieldInfoPtr_SecondDelay;

    static BlinkData()
    {
      Il2CppClassPointerStore<EmissionBlinker.BlinkData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EmissionBlinker>.NativeClassPtr, nameof (BlinkData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmissionBlinker.BlinkData>.NativeClassPtr);
      EmissionBlinker.BlinkData.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmissionBlinker.BlinkData>.NativeClassPtr, nameof (Id));
      EmissionBlinker.BlinkData.NativeFieldInfoPtr_InitialDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmissionBlinker.BlinkData>.NativeClassPtr, nameof (InitialDelay));
      EmissionBlinker.BlinkData.NativeFieldInfoPtr_FirstDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmissionBlinker.BlinkData>.NativeClassPtr, nameof (FirstDelay));
      EmissionBlinker.BlinkData.NativeFieldInfoPtr_SecondDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmissionBlinker.BlinkData>.NativeClassPtr, nameof (SecondDelay));
    }

    public BlinkData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public BlinkData()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmissionBlinker.BlinkData>.NativeClassPtr))
    {
    }

    public unsafe string Id
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker.BlinkData.NativeFieldInfoPtr_Id)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker.BlinkData.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float InitialDelay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker.BlinkData.NativeFieldInfoPtr_InitialDelay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker.BlinkData.NativeFieldInfoPtr_InitialDelay)) = value;
      }
    }

    public unsafe float FirstDelay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker.BlinkData.NativeFieldInfoPtr_FirstDelay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker.BlinkData.NativeFieldInfoPtr_FirstDelay)) = value;
      }
    }

    public unsafe float SecondDelay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker.BlinkData.NativeFieldInfoPtr_SecondDelay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker.BlinkData.NativeFieldInfoPtr_SecondDelay)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Effects.EmissionBlinker+<BlinkCycle>d__4")]
  public sealed class _BlinkCycle_d__4 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_blinkData;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_cancellationToken;
    private static readonly System.IntPtr NativeFieldInfoPtr__emissionId_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _BlinkCycle_d__4()
    {
      Il2CppClassPointerStore<EmissionBlinker._BlinkCycle_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EmissionBlinker>.NativeClassPtr, "<BlinkCycle>d__4");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmissionBlinker._BlinkCycle_d__4>.NativeClassPtr);
      EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmissionBlinker._BlinkCycle_d__4>.NativeClassPtr, "<>1__state");
      EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmissionBlinker._BlinkCycle_d__4>.NativeClassPtr, "<>t__builder");
      EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr_blinkData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmissionBlinker._BlinkCycle_d__4>.NativeClassPtr, nameof (blinkData));
      EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmissionBlinker._BlinkCycle_d__4>.NativeClassPtr, "<>4__this");
      EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmissionBlinker._BlinkCycle_d__4>.NativeClassPtr, nameof (cancellationToken));
      EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr__emissionId_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmissionBlinker._BlinkCycle_d__4>.NativeClassPtr, "<emissionId>5__2");
      EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmissionBlinker._BlinkCycle_d__4>.NativeClassPtr, "<>u__1");
      EmissionBlinker._BlinkCycle_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmissionBlinker._BlinkCycle_d__4>.NativeClassPtr, 100675762);
      EmissionBlinker._BlinkCycle_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmissionBlinker._BlinkCycle_d__4>.NativeClassPtr, 100675763);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 119347, RefRangeEnd = 119348, XrefRangeStart = 119277, XrefRangeEnd = 119347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(EmissionBlinker._BlinkCycle_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(EmissionBlinker._BlinkCycle_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _BlinkCycle_d__4(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _BlinkCycle_d__4()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmissionBlinker._BlinkCycle_d__4>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public EmissionBlinker.BlinkData blinkData
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr_blinkData);
        return new EmissionBlinker.BlinkData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EmissionBlinker.BlinkData>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr_blinkData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EmissionBlinker.BlinkData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EmissionBlinker __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (EmissionBlinker) null : Il2CppObjectPool.Get<EmissionBlinker>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public CancellationToken cancellationToken
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr_cancellationToken);
        return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int _emissionId_5__2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr__emissionId_5__2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr__emissionId_5__2)) = value;
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionBlinker._BlinkCycle_d__4.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
