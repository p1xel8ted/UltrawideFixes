// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.UISliderControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace Rewired.UI.ControlMapper;

public class UISliderControl(System.IntPtr pointer) : UIControl(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_iconImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_slider;
  private static readonly System.IntPtr NativeFieldInfoPtr__showIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr__showSlider;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_showIcon_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_showIcon_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_showSlider_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_showSlider_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCancelCallback_Public_Virtual_Void_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UISliderControl()
  {
    Il2CppClassPointerStore<UISliderControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (UISliderControl));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr);
    UISliderControl.NativeFieldInfoPtr_iconImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, nameof (iconImage));
    UISliderControl.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, nameof (slider));
    UISliderControl.NativeFieldInfoPtr__showIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, nameof (_showIcon));
    UISliderControl.NativeFieldInfoPtr__showSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, nameof (_showSlider));
    UISliderControl.NativeMethodInfoPtr_get_showIcon_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, 100670075);
    UISliderControl.NativeMethodInfoPtr_set_showIcon_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, 100670076);
    UISliderControl.NativeMethodInfoPtr_get_showSlider_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, 100670077);
    UISliderControl.NativeMethodInfoPtr_set_showSlider_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, 100670078);
    UISliderControl.NativeMethodInfoPtr_SetCancelCallback_Public_Virtual_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, 100670079);
    UISliderControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, 100670080);
  }

  public unsafe bool showIcon
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UISliderControl.NativeMethodInfoPtr_get_showIcon_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80192, XrefRangeEnd = 80198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISliderControl.NativeMethodInfoPtr_set_showIcon_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool showSlider
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UISliderControl.NativeMethodInfoPtr_get_showSlider_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80198, XrefRangeEnd = 80204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISliderControl.NativeMethodInfoPtr_set_showSlider_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80204, XrefRangeEnd = 80255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void SetCancelCallback(Il2CppSystem.Action cancelCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cancelCallback)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UISliderControl.NativeMethodInfoPtr_SetCancelCallback_Public_Virtual_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UISliderControl()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISliderControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Image iconImage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISliderControl.NativeFieldInfoPtr_iconImage));
      return num == System.IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISliderControl.NativeFieldInfoPtr_iconImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider slider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISliderControl.NativeFieldInfoPtr_slider));
      return num == System.IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISliderControl.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _showIcon
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISliderControl.NativeFieldInfoPtr__showIcon));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISliderControl.NativeFieldInfoPtr__showIcon)) = value;
    }
  }

  public unsafe bool _showSlider
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISliderControl.NativeFieldInfoPtr__showSlider));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISliderControl.NativeFieldInfoPtr__showSlider)) = value;
    }
  }

  [ObfuscatedName("Rewired.UI.ControlMapper.UISliderControl+<>c__DisplayClass10_0")]
  public sealed class __c__DisplayClass10_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_cancelCallback;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetCancelCallback_b__0_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetCancelCallback_b__1_Internal_Void_BaseEventData_0;

    static __c__DisplayClass10_0()
    {
      Il2CppClassPointerStore<UISliderControl.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, "<>c__DisplayClass10_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISliderControl.__c__DisplayClass10_0>.NativeClassPtr);
      UISliderControl.__c__DisplayClass10_0.NativeFieldInfoPtr_cancelCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISliderControl.__c__DisplayClass10_0>.NativeClassPtr, nameof (cancelCallback));
      UISliderControl.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderControl.__c__DisplayClass10_0>.NativeClassPtr, 100670081);
      UISliderControl.__c__DisplayClass10_0.NativeMethodInfoPtr__SetCancelCallback_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderControl.__c__DisplayClass10_0>.NativeClassPtr, 100670082);
      UISliderControl.__c__DisplayClass10_0.NativeMethodInfoPtr__SetCancelCallback_b__1_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderControl.__c__DisplayClass10_0>.NativeClassPtr, 100670083);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass10_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISliderControl.__c__DisplayClass10_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISliderControl.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80191, XrefRangeEnd = 80192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _SetCancelCallback_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISliderControl.__c__DisplayClass10_0.NativeMethodInfoPtr__SetCancelCallback_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _SetCancelCallback_b__1(BaseEventData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISliderControl.__c__DisplayClass10_0.NativeMethodInfoPtr__SetCancelCallback_b__1_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Il2CppSystem.Action cancelCallback
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISliderControl.__c__DisplayClass10_0.NativeFieldInfoPtr_cancelCallback));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISliderControl.__c__DisplayClass10_0.NativeFieldInfoPtr_cancelCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
