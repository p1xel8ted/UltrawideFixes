// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.UIControlSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
namespace Rewired.UI.ControlMapper;

public class UIControlSet(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_title;
  private static readonly System.IntPtr NativeFieldInfoPtr__controls;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_controls_Private_get_Dictionary_2_Int32_UIControl_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTitle_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetControl_Public_T_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateSlider_Public_UISliderControl_GameObject_Sprite_Single_Single_Action_2_Int32_Single_Action_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIControlSet()
  {
    Il2CppClassPointerStore<UIControlSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (UIControlSet));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr);
    UIControlSet.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr, nameof (title));
    UIControlSet.NativeFieldInfoPtr__controls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr, nameof (_controls));
    UIControlSet.NativeMethodInfoPtr_get_controls_Private_get_Dictionary_2_Int32_UIControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr, 100670049);
    UIControlSet.NativeMethodInfoPtr_SetTitle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr, 100670050);
    UIControlSet.NativeMethodInfoPtr_GetControl_Public_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr, 100670051);
    UIControlSet.NativeMethodInfoPtr_CreateSlider_Public_UISliderControl_GameObject_Sprite_Single_Single_Action_2_Int32_Single_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr, 100670052);
    UIControlSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr, 100670053);
  }

  public unsafe Dictionary<int, UIControl> controls
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 79951, RefRangeEnd = 79952, XrefRangeStart = 79945, XrefRangeEnd = 79951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIControlSet.NativeMethodInfoPtr_get_controls_Private_get_Dictionary_2_Int32_UIControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Dictionary<int, UIControl>) null : Il2CppObjectPool.Get<Dictionary<int, UIControl>>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 79956, RefRangeEnd = 79957, XrefRangeStart = 79952, XrefRangeEnd = 79956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetTitle(string text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIControlSet.NativeMethodInfoPtr_SetTitle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 79964, RefRangeEnd = 79968, XrefRangeStart = 79957, XrefRangeEnd = 79964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe T GetControl<T>(int uniqueId) where T : UIControl
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &uniqueId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIControlSet.MethodInfoStoreGeneric_GetControl_Public_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 80020, RefRangeEnd = 80021, XrefRangeStart = 79968, XrefRangeEnd = 80020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UISliderControl CreateSlider(
    GameObject prefab,
    Sprite icon,
    float minValue,
    float maxValue,
    Il2CppSystem.Action<int, float> valueChangedCallback,
    Il2CppSystem.Action<int> cancelCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) icon);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &minValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) valueChangedCallback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cancelCallback);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIControlSet.NativeMethodInfoPtr_CreateSlider_Public_UISliderControl_GameObject_Sprite_Single_Single_Action_2_Int32_Single_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UISliderControl) null : Il2CppObjectPool.Get<UISliderControl>(num3);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIControlSet()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIControlSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe TMP_Text title
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlSet.NativeFieldInfoPtr_title));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIControlSet.NativeFieldInfoPtr_title), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<int, UIControl> _controls
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlSet.NativeFieldInfoPtr__controls));
      return num == System.IntPtr.Zero ? (Dictionary<int, UIControl>) null : Il2CppObjectPool.Get<Dictionary<int, UIControl>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIControlSet.NativeFieldInfoPtr__controls), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("Rewired.UI.ControlMapper.UIControlSet+<>c__DisplayClass6_0")]
  public sealed class __c__DisplayClass6_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_valueChangedCallback;
    private static readonly System.IntPtr NativeFieldInfoPtr_control;
    private static readonly System.IntPtr NativeFieldInfoPtr_cancelCallback;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CreateSlider_b__0_Internal_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CreateSlider_b__1_Internal_Void_0;

    static __c__DisplayClass6_0()
    {
      Il2CppClassPointerStore<UIControlSet.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr, "<>c__DisplayClass6_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIControlSet.__c__DisplayClass6_0>.NativeClassPtr);
      UIControlSet.__c__DisplayClass6_0.NativeFieldInfoPtr_valueChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlSet.__c__DisplayClass6_0>.NativeClassPtr, nameof (valueChangedCallback));
      UIControlSet.__c__DisplayClass6_0.NativeFieldInfoPtr_control = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlSet.__c__DisplayClass6_0>.NativeClassPtr, nameof (control));
      UIControlSet.__c__DisplayClass6_0.NativeFieldInfoPtr_cancelCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlSet.__c__DisplayClass6_0>.NativeClassPtr, nameof (cancelCallback));
      UIControlSet.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlSet.__c__DisplayClass6_0>.NativeClassPtr, 100670054);
      UIControlSet.__c__DisplayClass6_0.NativeMethodInfoPtr__CreateSlider_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlSet.__c__DisplayClass6_0>.NativeClassPtr, 100670055);
      UIControlSet.__c__DisplayClass6_0.NativeMethodInfoPtr__CreateSlider_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlSet.__c__DisplayClass6_0>.NativeClassPtr, 100670056);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass6_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIControlSet.__c__DisplayClass6_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIControlSet.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79943, XrefRangeEnd = 79944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _CreateSlider_b__0(float value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIControlSet.__c__DisplayClass6_0.NativeMethodInfoPtr__CreateSlider_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79944, XrefRangeEnd = 79945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _CreateSlider_b__1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIControlSet.__c__DisplayClass6_0.NativeMethodInfoPtr__CreateSlider_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Il2CppSystem.Action<int, float> valueChangedCallback
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlSet.__c__DisplayClass6_0.NativeFieldInfoPtr_valueChangedCallback));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action<int, float>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<int, float>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIControlSet.__c__DisplayClass6_0.NativeFieldInfoPtr_valueChangedCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UISliderControl control
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlSet.__c__DisplayClass6_0.NativeFieldInfoPtr_control));
        return num == System.IntPtr.Zero ? (UISliderControl) null : Il2CppObjectPool.Get<UISliderControl>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIControlSet.__c__DisplayClass6_0.NativeFieldInfoPtr_control), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<int> cancelCallback
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlSet.__c__DisplayClass6_0.NativeFieldInfoPtr_cancelCallback));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIControlSet.__c__DisplayClass6_0.NativeFieldInfoPtr_cancelCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_GetControl_Public_T_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UIControlSet.NativeMethodInfoPtr_GetControl_Public_T_Int32_0, Il2CppClassPointerStore<UIControlSet>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
