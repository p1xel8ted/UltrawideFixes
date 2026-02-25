// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.CustomizationScene.G_CUIColorPicker
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.CustomizationScene;

public class G_CUIColorPicker(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_alphaSlider;
  private static readonly System.IntPtr NativeFieldInfoPtr_alphaSliderBGImage;
  private static readonly System.IntPtr NativeFieldInfoPtr__color;
  private static readonly System.IntPtr NativeFieldInfoPtr__onValueChange;
  private static readonly System.IntPtr NativeFieldInfoPtr__update;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetOnValueChangeCallback_Public_Void_Action_1_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RGBToHSV_Private_Static_Void_Color_byref_Single_byref_Single_byref_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalMouse_Private_Static_Boolean_GameObject_byref_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetWidgetSize_Private_Static_Vector2_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GO_Private_GameObject_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Private_Void_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetRandomColor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__16_0_Private_Void_Single_0;

  static G_CUIColorPicker()
  {
    Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.CustomizationScene", nameof (G_CUIColorPicker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr);
    G_CUIColorPicker.NativeFieldInfoPtr_alphaSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, nameof (alphaSlider));
    G_CUIColorPicker.NativeFieldInfoPtr_alphaSliderBGImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, nameof (alphaSliderBGImage));
    G_CUIColorPicker.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, nameof (_color));
    G_CUIColorPicker.NativeFieldInfoPtr__onValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, nameof (_onValueChange));
    G_CUIColorPicker.NativeFieldInfoPtr__update = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, nameof (_update));
    G_CUIColorPicker.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100663660);
    G_CUIColorPicker.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100663661);
    G_CUIColorPicker.NativeMethodInfoPtr_SetOnValueChangeCallback_Public_Void_Action_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100663662);
    G_CUIColorPicker.NativeMethodInfoPtr_RGBToHSV_Private_Static_Void_Color_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100663663);
    G_CUIColorPicker.NativeMethodInfoPtr_GetLocalMouse_Private_Static_Boolean_GameObject_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100663664 /*0x06000170*/);
    G_CUIColorPicker.NativeMethodInfoPtr_GetWidgetSize_Private_Static_Vector2_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100663665);
    G_CUIColorPicker.NativeMethodInfoPtr_GO_Private_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100663666);
    G_CUIColorPicker.NativeMethodInfoPtr_Setup_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100663667);
    G_CUIColorPicker.NativeMethodInfoPtr_SetRandomColor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100663668);
    G_CUIColorPicker.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100663669);
    G_CUIColorPicker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100663670);
    G_CUIColorPicker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100663671);
    G_CUIColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100663672);
    G_CUIColorPicker.NativeMethodInfoPtr__Start_b__16_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100663673);
  }

  public unsafe Color Color
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363318, XrefRangeEnd = 363319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe void SetOnValueChangeCallback(Il2CppSystem.Action<Color> onValueChange)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_SetOnValueChangeCallback_Public_Void_Action_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 363331, RefRangeEnd = 363332, XrefRangeStart = 363319, XrefRangeEnd = 363331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RGBToHSV(Color color, out float h, out float s, out float v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref h;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref s;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref v;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_RGBToHSV_Private_Static_Void_Color_byref_Single_byref_Single_byref_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 363344, RefRangeEnd = 363348, XrefRangeStart = 363332, XrefRangeEnd = 363344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool GetLocalMouse(GameObject go, out Vector2 result)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) go);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_GetLocalMouse_Private_Static_Boolean_GameObject_byref_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363348, XrefRangeEnd = 363352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 GetWidgetSize(GameObject go)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) go)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_GetWidgetSize_Private_Static_Vector2_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363352, XrefRangeEnd = 363356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GameObject GO(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_GO_Private_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 363454, RefRangeEnd = 363465, XrefRangeStart = 363356, XrefRangeEnd = 363454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Setup(Color inputColor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inputColor
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_Setup_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363465, XrefRangeEnd = 363470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetRandomColor()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_SetRandomColor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363470, XrefRangeEnd = 363471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363471, XrefRangeEnd = 363481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363481, XrefRangeEnd = 363482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe G_CUIColorPicker()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void _Start_b__16_0(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr__Start_b__16_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Slider alphaSlider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr_alphaSlider));
      return num == System.IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr_alphaSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image alphaSliderBGImage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr_alphaSliderBGImage));
      return num == System.IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr_alphaSliderBGImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color _color
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr__color));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr__color)) = value;
    }
  }

  public unsafe Il2CppSystem.Action<Color> _onValueChange
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr__onValueChange));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<Color>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<Color>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr__onValueChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action _update
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr__update));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr__update), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("Tayx.Graphy.CustomizationScene.G_CUIColorPicker+<>c__DisplayClass13_0")]
  public sealed class __c__DisplayClass13_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_satvalTex;
    private static readonly System.IntPtr NativeFieldInfoPtr_satvalColors;
    private static readonly System.IntPtr NativeFieldInfoPtr_Hue;
    private static readonly System.IntPtr NativeFieldInfoPtr_hueColors;
    private static readonly System.IntPtr NativeFieldInfoPtr_resetSatValTexture;
    private static readonly System.IntPtr NativeFieldInfoPtr_Saturation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_result;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_hueGO;
    private static readonly System.IntPtr NativeFieldInfoPtr_dragH;
    private static readonly System.IntPtr NativeFieldInfoPtr_satvalGO;
    private static readonly System.IntPtr NativeFieldInfoPtr_dragSV;
    private static readonly System.IntPtr NativeFieldInfoPtr_hueSz;
    private static readonly System.IntPtr NativeFieldInfoPtr_applyHue;
    private static readonly System.IntPtr NativeFieldInfoPtr_applySaturationValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_hueKnob;
    private static readonly System.IntPtr NativeFieldInfoPtr_idle;
    private static readonly System.IntPtr NativeFieldInfoPtr_satvalSz;
    private static readonly System.IntPtr NativeFieldInfoPtr_satvalKnob;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Setup_b__0_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Setup_b__1_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Setup_b__2_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Setup_b__3_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Setup_b__4_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Setup_b__5_Internal_Void_0;

    static __c__DisplayClass13_0()
    {
      Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, "<>c__DisplayClass13_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr);
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, nameof (satvalTex));
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, nameof (satvalColors));
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_Hue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, nameof (Hue));
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, nameof (hueColors));
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_resetSatValTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, nameof (resetSatValTexture));
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_Saturation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, nameof (Saturation));
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, nameof (Value));
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, nameof (result));
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueGO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, nameof (hueGO));
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_dragH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, nameof (dragH));
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalGO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, nameof (satvalGO));
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_dragSV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, nameof (dragSV));
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueSz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, nameof (hueSz));
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_applyHue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, nameof (applyHue));
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_applySaturationValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, nameof (applySaturationValue));
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueKnob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, nameof (hueKnob));
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_idle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, nameof (idle));
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalSz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, nameof (satvalSz));
      G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalKnob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, nameof (satvalKnob));
      G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, 100663674);
      G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, 100663675);
      G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, 100663676);
      G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, 100663677);
      G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, 100663678);
      G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, 100663679);
      G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, 100663680 /*0x06000180*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass13_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363294, XrefRangeEnd = 363298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Setup_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363298, XrefRangeEnd = 363302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Setup_b__1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363302, XrefRangeEnd = 363305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Setup_b__2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363305, XrefRangeEnd = 363308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Setup_b__3()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363308, XrefRangeEnd = 363314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Setup_b__4()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363314, XrefRangeEnd = 363318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Setup_b__5()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Texture2D satvalTex
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalTex));
        return num == System.IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalTex), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<Color> satvalColors
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalColors));
        return num == System.IntPtr.Zero ? (Il2CppStructArray<Color>) null : Il2CppObjectPool.Get<Il2CppStructArray<Color>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalColors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float Hue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_Hue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_Hue)) = value;
      }
    }

    public unsafe Il2CppStructArray<Color> hueColors
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueColors));
        return num == System.IntPtr.Zero ? (Il2CppStructArray<Color>) null : Il2CppObjectPool.Get<Il2CppStructArray<Color>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueColors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action resetSatValTexture
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_resetSatValTexture));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_resetSatValTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float Saturation
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_Saturation));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_Saturation)) = value;
      }
    }

    public unsafe float Value
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_Value));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_Value)) = value;
      }
    }

    public unsafe GameObject result
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_result));
        return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe G_CUIColorPicker __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (G_CUIColorPicker) null : Il2CppObjectPool.Get<G_CUIColorPicker>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject hueGO
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueGO));
        return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueGO), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action dragH
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_dragH));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_dragH), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject satvalGO
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalGO));
        return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalGO), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action dragSV
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_dragSV));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_dragSV), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector2 hueSz
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueSz));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueSz)) = value;
      }
    }

    public unsafe Il2CppSystem.Action applyHue
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_applyHue));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_applyHue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action applySaturationValue
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_applySaturationValue));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_applySaturationValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject hueKnob
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueKnob));
        return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueKnob), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action idle
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_idle));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_idle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector2 satvalSz
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalSz));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalSz)) = value;
      }
    }

    public unsafe GameObject satvalKnob
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalKnob));
        return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalKnob), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
