// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.Elements.UIInteractionMarker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using SadCatStudios.Foundation.Events;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.UI.Elements;

public class UIInteractionMarker(System.IntPtr pointer) : UIPromt(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_promptFollow;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventDisposable;
  private static readonly System.IntPtr NativeFieldInfoPtr_active;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnShow_Private_Void_ShowTutorialPromptEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnHide_Private_Void_HideTutorialPromptEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForCloseAnim_Protected_Virtual_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_0;

  static UIInteractionMarker()
  {
    Il2CppClassPointerStore<UIInteractionMarker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI.Elements", nameof (UIInteractionMarker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIInteractionMarker>.NativeClassPtr);
    UIInteractionMarker.NativeFieldInfoPtr_promptFollow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInteractionMarker>.NativeClassPtr, nameof (promptFollow));
    UIInteractionMarker.NativeFieldInfoPtr_eventDisposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInteractionMarker>.NativeClassPtr, nameof (eventDisposable));
    UIInteractionMarker.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInteractionMarker>.NativeClassPtr, nameof (active));
    UIInteractionMarker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInteractionMarker>.NativeClassPtr, 100672346);
    UIInteractionMarker.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInteractionMarker>.NativeClassPtr, 100672347);
    UIInteractionMarker.NativeMethodInfoPtr_OnShow_Private_Void_ShowTutorialPromptEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInteractionMarker>.NativeClassPtr, 100672348);
    UIInteractionMarker.NativeMethodInfoPtr_OnHide_Private_Void_HideTutorialPromptEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInteractionMarker>.NativeClassPtr, 100672349);
    UIInteractionMarker.NativeMethodInfoPtr_WaitForCloseAnim_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInteractionMarker>.NativeClassPtr, 100672350);
    UIInteractionMarker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInteractionMarker>.NativeClassPtr, 100672351);
    UIInteractionMarker.NativeMethodInfoPtr___n__0_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInteractionMarker>.NativeClassPtr, 100672352);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100756, XrefRangeEnd = 100795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIInteractionMarker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100795, XrefRangeEnd = 100798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIInteractionMarker.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100798, XrefRangeEnd = 100805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnShow(ShowTutorialPromptEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) e))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIInteractionMarker.NativeMethodInfoPtr_OnShow_Private_Void_ShowTutorialPromptEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100805, XrefRangeEnd = 100807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnHide(HideTutorialPromptEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIInteractionMarker.NativeMethodInfoPtr_OnHide_Private_Void_HideTutorialPromptEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100807, XrefRangeEnd = 100811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator WaitForCloseAnim()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIInteractionMarker.NativeMethodInfoPtr_WaitForCloseAnim_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100811, XrefRangeEnd = 100815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIInteractionMarker()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIInteractionMarker>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIInteractionMarker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100815, XrefRangeEnd = 100819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator __n__0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIInteractionMarker.NativeMethodInfoPtr___n__0_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  public unsafe UIPromtFollow promptFollow
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIInteractionMarker.NativeFieldInfoPtr_promptFollow));
      return num == System.IntPtr.Zero ? (UIPromtFollow) null : Il2CppObjectPool.Get<UIPromtFollow>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIInteractionMarker.NativeFieldInfoPtr_promptFollow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.IDisposable eventDisposable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIInteractionMarker.NativeFieldInfoPtr_eventDisposable));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIInteractionMarker.NativeFieldInfoPtr_eventDisposable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool active
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIInteractionMarker.NativeFieldInfoPtr_active));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIInteractionMarker.NativeFieldInfoPtr_active)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.UI.Elements.UIInteractionMarker+<WaitForCloseAnim>d__7")]
  public sealed class _WaitForCloseAnim_d__7(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _WaitForCloseAnim_d__7()
    {
      Il2CppClassPointerStore<UIInteractionMarker._WaitForCloseAnim_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIInteractionMarker>.NativeClassPtr, "<WaitForCloseAnim>d__7");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIInteractionMarker._WaitForCloseAnim_d__7>.NativeClassPtr);
      UIInteractionMarker._WaitForCloseAnim_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInteractionMarker._WaitForCloseAnim_d__7>.NativeClassPtr, "<>1__state");
      UIInteractionMarker._WaitForCloseAnim_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInteractionMarker._WaitForCloseAnim_d__7>.NativeClassPtr, "<>2__current");
      UIInteractionMarker._WaitForCloseAnim_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInteractionMarker._WaitForCloseAnim_d__7>.NativeClassPtr, "<>4__this");
      UIInteractionMarker._WaitForCloseAnim_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInteractionMarker._WaitForCloseAnim_d__7>.NativeClassPtr, 100672353);
      UIInteractionMarker._WaitForCloseAnim_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInteractionMarker._WaitForCloseAnim_d__7>.NativeClassPtr, 100672354);
      UIInteractionMarker._WaitForCloseAnim_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInteractionMarker._WaitForCloseAnim_d__7>.NativeClassPtr, 100672355);
      UIInteractionMarker._WaitForCloseAnim_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInteractionMarker._WaitForCloseAnim_d__7>.NativeClassPtr, 100672356);
      UIInteractionMarker._WaitForCloseAnim_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInteractionMarker._WaitForCloseAnim_d__7>.NativeClassPtr, 100672357);
      UIInteractionMarker._WaitForCloseAnim_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInteractionMarker._WaitForCloseAnim_d__7>.NativeClassPtr, 100672358);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _WaitForCloseAnim_d__7(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIInteractionMarker._WaitForCloseAnim_d__7>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIInteractionMarker._WaitForCloseAnim_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIInteractionMarker._WaitForCloseAnim_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100746, XrefRangeEnd = 100751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIInteractionMarker._WaitForCloseAnim_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIInteractionMarker._WaitForCloseAnim_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100751, XrefRangeEnd = 100756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIInteractionMarker._WaitForCloseAnim_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIInteractionMarker._WaitForCloseAnim_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIInteractionMarker._WaitForCloseAnim_d__7.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIInteractionMarker._WaitForCloseAnim_d__7.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIInteractionMarker._WaitForCloseAnim_d__7.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIInteractionMarker._WaitForCloseAnim_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIInteractionMarker __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIInteractionMarker._WaitForCloseAnim_d__7.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UIInteractionMarker) null : Il2CppObjectPool.Get<UIInteractionMarker>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIInteractionMarker._WaitForCloseAnim_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
