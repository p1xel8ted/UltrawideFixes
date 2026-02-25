// Decompiled with JetBrains decompiler
// Type: TweenVec
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Unity.VisualScripting;
using UnityEngine;

#nullable disable
public class TweenVec(System.IntPtr pointer) : Unit(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_In;
  private static readonly System.IntPtr NativeFieldInfoPtr_Out;
  private static readonly System.IntPtr NativeFieldInfoPtr_Executing;
  private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
  private static readonly System.IntPtr NativeFieldInfoPtr_From;
  private static readonly System.IntPtr NativeFieldInfoPtr_To;
  private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
  private static readonly System.IntPtr NativeFieldInfoPtr_Vector;
  private static readonly System.IntPtr NativeMethodInfoPtr_Definition_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoTween_Private_IEnumerator_Flow_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TweenVec()
  {
    Il2CppClassPointerStore<TweenVec>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TweenVec));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenVec>.NativeClassPtr);
    TweenVec.NativeFieldInfoPtr_In = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenVec>.NativeClassPtr, nameof (In));
    TweenVec.NativeFieldInfoPtr_Out = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenVec>.NativeClassPtr, nameof (Out));
    TweenVec.NativeFieldInfoPtr_Executing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenVec>.NativeClassPtr, nameof (Executing));
    TweenVec.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenVec>.NativeClassPtr, nameof (Curve));
    TweenVec.NativeFieldInfoPtr_From = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenVec>.NativeClassPtr, nameof (From));
    TweenVec.NativeFieldInfoPtr_To = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenVec>.NativeClassPtr, nameof (To));
    TweenVec.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenVec>.NativeClassPtr, nameof (Duration));
    TweenVec.NativeFieldInfoPtr_Vector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenVec>.NativeClassPtr, nameof (Vector));
    TweenVec.NativeMethodInfoPtr_Definition_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenVec>.NativeClassPtr, 100663522 /*0x060000E2*/);
    TweenVec.NativeMethodInfoPtr_DoTween_Private_IEnumerator_Flow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenVec>.NativeClassPtr, 100663523 /*0x060000E3*/);
    TweenVec.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenVec>.NativeClassPtr, 100663524 /*0x060000E4*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20203, XrefRangeEnd = 20245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Definition()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TweenVec.NativeMethodInfoPtr_Definition_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20245, XrefRangeEnd = 20249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator DoTween(Flow flow)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) flow)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TweenVec.NativeMethodInfoPtr_DoTween_Private_IEnumerator_Flow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(70)]
  [CachedScanResults(RefRangeStart = 20250, RefRangeEnd = 20320, XrefRangeStart = 20249, XrefRangeEnd = 20250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TweenVec()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenVec>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TweenVec.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Unity.VisualScripting.ControlInput In
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec.NativeFieldInfoPtr_In));
      return num == System.IntPtr.Zero ? (Unity.VisualScripting.ControlInput) null : Il2CppObjectPool.Get<Unity.VisualScripting.ControlInput>(num);
    }
    [param: System.Runtime.InteropServices.In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TweenVec.NativeFieldInfoPtr_In), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Unity.VisualScripting.ControlOutput Out
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec.NativeFieldInfoPtr_Out));
      return num == System.IntPtr.Zero ? (Unity.VisualScripting.ControlOutput) null : Il2CppObjectPool.Get<Unity.VisualScripting.ControlOutput>(num);
    }
    [param: System.Runtime.InteropServices.In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TweenVec.NativeFieldInfoPtr_Out), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Unity.VisualScripting.ControlOutput Executing
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec.NativeFieldInfoPtr_Executing));
      return num == System.IntPtr.Zero ? (Unity.VisualScripting.ControlOutput) null : Il2CppObjectPool.Get<Unity.VisualScripting.ControlOutput>(num);
    }
    [param: System.Runtime.InteropServices.In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TweenVec.NativeFieldInfoPtr_Executing), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Unity.VisualScripting.ValueInput Curve
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec.NativeFieldInfoPtr_Curve));
      return num == System.IntPtr.Zero ? (Unity.VisualScripting.ValueInput) null : Il2CppObjectPool.Get<Unity.VisualScripting.ValueInput>(num);
    }
    [param: System.Runtime.InteropServices.In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TweenVec.NativeFieldInfoPtr_Curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Unity.VisualScripting.ValueInput From
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec.NativeFieldInfoPtr_From));
      return num == System.IntPtr.Zero ? (Unity.VisualScripting.ValueInput) null : Il2CppObjectPool.Get<Unity.VisualScripting.ValueInput>(num);
    }
    [param: System.Runtime.InteropServices.In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TweenVec.NativeFieldInfoPtr_From), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Unity.VisualScripting.ValueInput To
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec.NativeFieldInfoPtr_To));
      return num == System.IntPtr.Zero ? (Unity.VisualScripting.ValueInput) null : Il2CppObjectPool.Get<Unity.VisualScripting.ValueInput>(num);
    }
    [param: System.Runtime.InteropServices.In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TweenVec.NativeFieldInfoPtr_To), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Unity.VisualScripting.ValueInput Duration
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec.NativeFieldInfoPtr_Duration));
      return num == System.IntPtr.Zero ? (Unity.VisualScripting.ValueInput) null : Il2CppObjectPool.Get<Unity.VisualScripting.ValueInput>(num);
    }
    [param: System.Runtime.InteropServices.In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TweenVec.NativeFieldInfoPtr_Duration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Unity.VisualScripting.ValueOutput Vector
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec.NativeFieldInfoPtr_Vector));
      return num == System.IntPtr.Zero ? (Unity.VisualScripting.ValueOutput) null : Il2CppObjectPool.Get<Unity.VisualScripting.ValueOutput>(num);
    }
    [param: System.Runtime.InteropServices.In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TweenVec.NativeFieldInfoPtr_Vector), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("TweenVec+<DoTween>d__9")]
  public sealed class _DoTween_d__9(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_flow;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__duration_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__curve_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__from_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__to_5__5;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__6;
    private static readonly System.IntPtr NativeFieldInfoPtr__percent_5__7;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _DoTween_d__9()
    {
      Il2CppClassPointerStore<TweenVec._DoTween_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TweenVec>.NativeClassPtr, "<DoTween>d__9");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenVec._DoTween_d__9>.NativeClassPtr);
      TweenVec._DoTween_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenVec._DoTween_d__9>.NativeClassPtr, "<>1__state");
      TweenVec._DoTween_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenVec._DoTween_d__9>.NativeClassPtr, "<>2__current");
      TweenVec._DoTween_d__9.NativeFieldInfoPtr_flow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenVec._DoTween_d__9>.NativeClassPtr, nameof (flow));
      TweenVec._DoTween_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenVec._DoTween_d__9>.NativeClassPtr, "<>4__this");
      TweenVec._DoTween_d__9.NativeFieldInfoPtr__duration_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenVec._DoTween_d__9>.NativeClassPtr, "<duration>5__2");
      TweenVec._DoTween_d__9.NativeFieldInfoPtr__curve_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenVec._DoTween_d__9>.NativeClassPtr, "<curve>5__3");
      TweenVec._DoTween_d__9.NativeFieldInfoPtr__from_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenVec._DoTween_d__9>.NativeClassPtr, "<from>5__4");
      TweenVec._DoTween_d__9.NativeFieldInfoPtr__to_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenVec._DoTween_d__9>.NativeClassPtr, "<to>5__5");
      TweenVec._DoTween_d__9.NativeFieldInfoPtr__timer_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenVec._DoTween_d__9>.NativeClassPtr, "<timer>5__6");
      TweenVec._DoTween_d__9.NativeFieldInfoPtr__percent_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenVec._DoTween_d__9>.NativeClassPtr, "<percent>5__7");
      TweenVec._DoTween_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenVec._DoTween_d__9>.NativeClassPtr, 100663525 /*0x060000E5*/);
      TweenVec._DoTween_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenVec._DoTween_d__9>.NativeClassPtr, 100663526 /*0x060000E6*/);
      TweenVec._DoTween_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenVec._DoTween_d__9>.NativeClassPtr, 100663527 /*0x060000E7*/);
      TweenVec._DoTween_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenVec._DoTween_d__9>.NativeClassPtr, 100663528 /*0x060000E8*/);
      TweenVec._DoTween_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenVec._DoTween_d__9>.NativeClassPtr, 100663529 /*0x060000E9*/);
      TweenVec._DoTween_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenVec._DoTween_d__9>.NativeClassPtr, 100663530 /*0x060000EA*/);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _DoTween_d__9(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenVec._DoTween_d__9>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TweenVec._DoTween_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TweenVec._DoTween_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20194, XrefRangeEnd = 20198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TweenVec._DoTween_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TweenVec._DoTween_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20198, XrefRangeEnd = 20203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TweenVec._DoTween_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TweenVec._DoTween_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr___1__state));
      }
      [param: System.Runtime.InteropServices.In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: System.Runtime.InteropServices.In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Flow flow
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr_flow));
        return num == System.IntPtr.Zero ? (Flow) null : Il2CppObjectPool.Get<Flow>(num);
      }
      [param: System.Runtime.InteropServices.In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr_flow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TweenVec __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (TweenVec) null : Il2CppObjectPool.Get<TweenVec>(num);
      }
      [param: System.Runtime.InteropServices.In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _duration_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr__duration_5__2));
      }
      [param: System.Runtime.InteropServices.In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr__duration_5__2)) = value;
      }
    }

    public unsafe AnimationCurve _curve_5__3
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr__curve_5__3));
        return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
      }
      [param: System.Runtime.InteropServices.In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr__curve_5__3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 _from_5__4
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr__from_5__4));
      }
      [param: System.Runtime.InteropServices.In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr__from_5__4)) = value;
      }
    }

    public unsafe Vector3 _to_5__5
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr__to_5__5));
      }
      [param: System.Runtime.InteropServices.In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr__to_5__5)) = value;
      }
    }

    public unsafe float _timer_5__6
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr__timer_5__6));
      }
      [param: System.Runtime.InteropServices.In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr__timer_5__6)) = value;
      }
    }

    public unsafe float _percent_5__7
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr__percent_5__7));
      }
      [param: System.Runtime.InteropServices.In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenVec._DoTween_d__9.NativeFieldInfoPtr__percent_5__7)) = value;
      }
    }
  }
}
