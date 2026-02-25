// Decompiled with JetBrains decompiler
// Type: Replaced.Scripts.UI.UIGameIntroScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Replaced.Scripts.UI;

public class UIGameIntroScreen(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_shownScreens;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIGameIntroScreen()
  {
    Il2CppClassPointerStore<UIGameIntroScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Replaced.Scripts.UI", nameof (UIGameIntroScreen));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIGameIntroScreen>.NativeClassPtr);
    UIGameIntroScreen.NativeFieldInfoPtr_shownScreens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIGameIntroScreen>.NativeClassPtr, nameof (shownScreens));
    UIGameIntroScreen.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIGameIntroScreen>.NativeClassPtr, 100670710);
    UIGameIntroScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIGameIntroScreen>.NativeClassPtr, 100670711);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87774, XrefRangeEnd = 87778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIGameIntroScreen.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIGameIntroScreen()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIGameIntroScreen>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIGameIntroScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<UIGameIntroScreen.ScreenInfo> shownScreens
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen.NativeFieldInfoPtr_shownScreens));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<UIGameIntroScreen.ScreenInfo>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<UIGameIntroScreen.ScreenInfo>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen.NativeFieldInfoPtr_shownScreens), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class ScreenInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Group;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowingCurve;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static ScreenInfo()
    {
      Il2CppClassPointerStore<UIGameIntroScreen.ScreenInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIGameIntroScreen>.NativeClassPtr, nameof (ScreenInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIGameIntroScreen.ScreenInfo>.NativeClassPtr);
      UIGameIntroScreen.ScreenInfo.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIGameIntroScreen.ScreenInfo>.NativeClassPtr, nameof (Group));
      UIGameIntroScreen.ScreenInfo.NativeFieldInfoPtr_ShowingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIGameIntroScreen.ScreenInfo>.NativeClassPtr, nameof (ShowingCurve));
      UIGameIntroScreen.ScreenInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIGameIntroScreen.ScreenInfo>.NativeClassPtr, 100670712);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ScreenInfo()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIGameIntroScreen.ScreenInfo>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIGameIntroScreen.ScreenInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe CanvasGroup Group
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen.ScreenInfo.NativeFieldInfoPtr_Group));
        return num == System.IntPtr.Zero ? (CanvasGroup) null : Il2CppObjectPool.Get<CanvasGroup>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen.ScreenInfo.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCurve ShowingCurve
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen.ScreenInfo.NativeFieldInfoPtr_ShowingCurve));
        return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen.ScreenInfo.NativeFieldInfoPtr_ShowingCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Replaced.Scripts.UI.UIGameIntroScreen+<Start>d__2")]
  public sealed class _Start_d__2(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap2;
    private static readonly System.IntPtr NativeFieldInfoPtr__screen_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__5;
    private static readonly System.IntPtr NativeFieldInfoPtr__overTime_5__6;
    private static readonly System.IntPtr NativeFieldInfoPtr__keyPressed_5__7;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _Start_d__2()
    {
      Il2CppClassPointerStore<UIGameIntroScreen._Start_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIGameIntroScreen>.NativeClassPtr, "<Start>d__2");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIGameIntroScreen._Start_d__2>.NativeClassPtr);
      UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIGameIntroScreen._Start_d__2>.NativeClassPtr, "<>1__state");
      UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIGameIntroScreen._Start_d__2>.NativeClassPtr, "<>2__current");
      UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIGameIntroScreen._Start_d__2>.NativeClassPtr, "<>4__this");
      UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIGameIntroScreen._Start_d__2>.NativeClassPtr, "<>7__wrap1");
      UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIGameIntroScreen._Start_d__2>.NativeClassPtr, "<>7__wrap2");
      UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr__screen_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIGameIntroScreen._Start_d__2>.NativeClassPtr, "<screen>5__4");
      UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr__timer_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIGameIntroScreen._Start_d__2>.NativeClassPtr, "<timer>5__5");
      UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr__overTime_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIGameIntroScreen._Start_d__2>.NativeClassPtr, "<overTime>5__6");
      UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr__keyPressed_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIGameIntroScreen._Start_d__2>.NativeClassPtr, "<keyPressed>5__7");
      UIGameIntroScreen._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIGameIntroScreen._Start_d__2>.NativeClassPtr, 100670713);
      UIGameIntroScreen._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIGameIntroScreen._Start_d__2>.NativeClassPtr, 100670714);
      UIGameIntroScreen._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIGameIntroScreen._Start_d__2>.NativeClassPtr, 100670715);
      UIGameIntroScreen._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIGameIntroScreen._Start_d__2>.NativeClassPtr, 100670716);
      UIGameIntroScreen._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIGameIntroScreen._Start_d__2>.NativeClassPtr, 100670717);
      UIGameIntroScreen._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIGameIntroScreen._Start_d__2>.NativeClassPtr, 100670718);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Start_d__2(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIGameIntroScreen._Start_d__2>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIGameIntroScreen._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIGameIntroScreen._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87757, XrefRangeEnd = 87769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIGameIntroScreen._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIGameIntroScreen._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87769, XrefRangeEnd = 87774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIGameIntroScreen._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIGameIntroScreen._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIGameIntroScreen __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UIGameIntroScreen) null : Il2CppObjectPool.Get<UIGameIntroScreen>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<UIGameIntroScreen.ScreenInfo> __7__wrap1
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr___7__wrap1));
        return num == System.IntPtr.Zero ? (Il2CppReferenceArray<UIGameIntroScreen.ScreenInfo>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<UIGameIntroScreen.ScreenInfo>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int __7__wrap2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr___7__wrap2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr___7__wrap2)) = value;
      }
    }

    public unsafe UIGameIntroScreen.ScreenInfo _screen_5__4
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr__screen_5__4));
        return num == System.IntPtr.Zero ? (UIGameIntroScreen.ScreenInfo) null : Il2CppObjectPool.Get<UIGameIntroScreen.ScreenInfo>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr__screen_5__4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _timer_5__5
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr__timer_5__5));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr__timer_5__5)) = value;
      }
    }

    public unsafe float _overTime_5__6
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr__overTime_5__6));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr__overTime_5__6)) = value;
      }
    }

    public unsafe bool _keyPressed_5__7
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr__keyPressed_5__7));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIGameIntroScreen._Start_d__2.NativeFieldInfoPtr__keyPressed_5__7)) = value;
      }
    }
  }
}
