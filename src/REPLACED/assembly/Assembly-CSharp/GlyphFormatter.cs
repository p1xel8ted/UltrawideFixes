// Decompiled with JetBrains decompiler
// Type: GlyphFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using Rewired;
using System.Runtime.InteropServices;
using TMPro;

#nullable disable
public static class GlyphFormatter : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_joystickFormat;
  private static readonly System.IntPtr NativeFieldInfoPtr_keyNameFormat;
  private static readonly System.IntPtr NativeFieldInfoPtr_notFound;
  private static readonly System.IntPtr NativeFieldInfoPtr_KEYBOARD;
  private static readonly System.IntPtr NativeFieldInfoPtr_MOUSE;
  private static readonly System.IntPtr NativeFieldInfoPtr_SONY;
  private static readonly System.IntPtr NativeFieldInfoPtr_SONY_HARDWARE;
  private static readonly System.IntPtr NativeFieldInfoPtr_XBOX;
  private static readonly System.IntPtr NativeFieldInfoPtr_NINTENDO_HARDWARE;
  private static readonly System.IntPtr NativeFieldInfoPtr_NINTENDO;
  private static readonly System.IntPtr NativeFieldInfoPtr_actionElementMaps;
  private static readonly System.IntPtr NativeFieldInfoPtr_keyboardStringBuilder;
  private static readonly System.IntPtr NativeFieldInfoPtr_keyIndexToXbox;
  private static readonly System.IntPtr NativeFieldInfoPtr_keyIndexToSony;
  private static readonly System.IntPtr NativeFieldInfoPtr_spriteAssetCache;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTextRepresentationForKey_Public_Static_String_Controller_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSpriteButtonName_Public_Static_String_Controller_ActionElementMap_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ControllerName_Public_Static_String_Controller_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetController_Public_Static_Controller_Player_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FormattedString_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGlyph_Private_Static_String_InputAction_AxisRange_0;

  static GlyphFormatter()
  {
    Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (GlyphFormatter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr);
    GlyphFormatter.NativeFieldInfoPtr_joystickFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, nameof (joystickFormat));
    GlyphFormatter.NativeFieldInfoPtr_keyNameFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, nameof (keyNameFormat));
    GlyphFormatter.NativeFieldInfoPtr_notFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, nameof (notFound));
    GlyphFormatter.NativeFieldInfoPtr_KEYBOARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, nameof (KEYBOARD));
    GlyphFormatter.NativeFieldInfoPtr_MOUSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, nameof (MOUSE));
    GlyphFormatter.NativeFieldInfoPtr_SONY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, nameof (SONY));
    GlyphFormatter.NativeFieldInfoPtr_SONY_HARDWARE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, nameof (SONY_HARDWARE));
    GlyphFormatter.NativeFieldInfoPtr_XBOX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, nameof (XBOX));
    GlyphFormatter.NativeFieldInfoPtr_NINTENDO_HARDWARE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, nameof (NINTENDO_HARDWARE));
    GlyphFormatter.NativeFieldInfoPtr_NINTENDO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, nameof (NINTENDO));
    GlyphFormatter.NativeFieldInfoPtr_actionElementMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, nameof (actionElementMaps));
    GlyphFormatter.NativeFieldInfoPtr_keyboardStringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, nameof (keyboardStringBuilder));
    GlyphFormatter.NativeFieldInfoPtr_keyIndexToXbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, nameof (keyIndexToXbox));
    GlyphFormatter.NativeFieldInfoPtr_keyIndexToSony = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, nameof (keyIndexToSony));
    GlyphFormatter.NativeFieldInfoPtr_spriteAssetCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, nameof (spriteAssetCache));
    GlyphFormatter.NativeMethodInfoPtr_GetTextRepresentationForKey_Public_Static_String_Controller_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, 100663575);
    GlyphFormatter.NativeMethodInfoPtr_GetSpriteButtonName_Public_Static_String_Controller_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, 100663576);
    GlyphFormatter.NativeMethodInfoPtr_ControllerName_Public_Static_String_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, 100663577);
    GlyphFormatter.NativeMethodInfoPtr_GetController_Public_Static_Controller_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, 100663578);
    GlyphFormatter.NativeMethodInfoPtr_FormattedString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, 100663579);
    GlyphFormatter.NativeMethodInfoPtr_GetGlyph_Private_Static_String_InputAction_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, 100663580);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 21027, RefRangeEnd = 21031, XrefRangeStart = 20962, XrefRangeEnd = 21027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetTextRepresentationForKey(Controller controller, string buttonName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(buttonName);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphFormatter.NativeMethodInfoPtr_GetTextRepresentationForKey_Public_Static_String_Controller_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 21051, RefRangeEnd = 21055, XrefRangeStart = 21031, XrefRangeEnd = 21051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetSpriteButtonName(
    Controller controller,
    ActionElementMap elementMap)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) elementMap);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphFormatter.NativeMethodInfoPtr_GetSpriteButtonName_Public_Static_String_Controller_ActionElementMap_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21075, RefRangeEnd = 21078, XrefRangeStart = 21055, XrefRangeEnd = 21075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ControllerName(Controller controller)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphFormatter.NativeMethodInfoPtr_ControllerName_Public_Static_String_Controller_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 21081, RefRangeEnd = 21086, XrefRangeStart = 21078, XrefRangeEnd = 21081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Controller GetController(Player player)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphFormatter.NativeMethodInfoPtr_GetController_Public_Static_Controller_Player_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Controller) null : Il2CppObjectPool.Get<Controller>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 21129, RefRangeEnd = 21130, XrefRangeStart = 21086, XrefRangeEnd = 21129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string FormattedString(string originalString)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(originalString)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphFormatter.NativeMethodInfoPtr_FormattedString_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21241, RefRangeEnd = 21244, XrefRangeStart = 21130, XrefRangeEnd = 21241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetGlyph(SadCatStudios.PlayerInput.InputAction inputAction, AxisRange axisRange)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &inputAction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &axisRange;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphFormatter.NativeMethodInfoPtr_GetGlyph_Private_Static_String_InputAction_AxisRange_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public GlyphFormatter(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string joystickFormat
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GlyphFormatter.NativeFieldInfoPtr_joystickFormat, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlyphFormatter.NativeFieldInfoPtr_joystickFormat, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string keyNameFormat
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GlyphFormatter.NativeFieldInfoPtr_keyNameFormat, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlyphFormatter.NativeFieldInfoPtr_keyNameFormat, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string notFound
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GlyphFormatter.NativeFieldInfoPtr_notFound, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlyphFormatter.NativeFieldInfoPtr_notFound, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string KEYBOARD
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GlyphFormatter.NativeFieldInfoPtr_KEYBOARD, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlyphFormatter.NativeFieldInfoPtr_KEYBOARD, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string MOUSE
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GlyphFormatter.NativeFieldInfoPtr_MOUSE, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlyphFormatter.NativeFieldInfoPtr_MOUSE, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string SONY
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GlyphFormatter.NativeFieldInfoPtr_SONY, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlyphFormatter.NativeFieldInfoPtr_SONY, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string SONY_HARDWARE
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GlyphFormatter.NativeFieldInfoPtr_SONY_HARDWARE, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlyphFormatter.NativeFieldInfoPtr_SONY_HARDWARE, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string XBOX
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GlyphFormatter.NativeFieldInfoPtr_XBOX, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlyphFormatter.NativeFieldInfoPtr_XBOX, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string NINTENDO_HARDWARE
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GlyphFormatter.NativeFieldInfoPtr_NINTENDO_HARDWARE, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlyphFormatter.NativeFieldInfoPtr_NINTENDO_HARDWARE, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string NINTENDO
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GlyphFormatter.NativeFieldInfoPtr_NINTENDO, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlyphFormatter.NativeFieldInfoPtr_NINTENDO, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe List<ActionElementMap> actionElementMaps
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GlyphFormatter.NativeFieldInfoPtr_actionElementMaps, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (List<ActionElementMap>) null : Il2CppObjectPool.Get<List<ActionElementMap>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlyphFormatter.NativeFieldInfoPtr_actionElementMaps, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe StringBuilder keyboardStringBuilder
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GlyphFormatter.NativeFieldInfoPtr_keyboardStringBuilder, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlyphFormatter.NativeFieldInfoPtr_keyboardStringBuilder, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<int, string> keyIndexToXbox
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GlyphFormatter.NativeFieldInfoPtr_keyIndexToXbox, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Dictionary<int, string>) null : Il2CppObjectPool.Get<Dictionary<int, string>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlyphFormatter.NativeFieldInfoPtr_keyIndexToXbox, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<int, string> keyIndexToSony
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GlyphFormatter.NativeFieldInfoPtr_keyIndexToSony, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Dictionary<int, string>) null : Il2CppObjectPool.Get<Dictionary<int, string>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlyphFormatter.NativeFieldInfoPtr_keyIndexToSony, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<string, Il2CppSystem.ValueTuple<TMP_SpriteAsset, Dictionary<string, uint>>> spriteAssetCache
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GlyphFormatter.NativeFieldInfoPtr_spriteAssetCache, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Dictionary<string, Il2CppSystem.ValueTuple<TMP_SpriteAsset, Dictionary<string, uint>>>) null : Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.ValueTuple<TMP_SpriteAsset, Dictionary<string, uint>>>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlyphFormatter.NativeFieldInfoPtr_spriteAssetCache, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("GlyphFormatter+<>c__DisplayClass20_0")]
  public sealed class __c__DisplayClass20_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_controller;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetGlyph_b__0_Internal_Boolean_ActionElementMap_0;

    static __c__DisplayClass20_0()
    {
      Il2CppClassPointerStore<GlyphFormatter.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlyphFormatter>.NativeClassPtr, "<>c__DisplayClass20_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphFormatter.__c__DisplayClass20_0>.NativeClassPtr);
      GlyphFormatter.__c__DisplayClass20_0.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphFormatter.__c__DisplayClass20_0>.NativeClassPtr, nameof (controller));
      GlyphFormatter.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphFormatter.__c__DisplayClass20_0>.NativeClassPtr, 100663582);
      GlyphFormatter.__c__DisplayClass20_0.NativeMethodInfoPtr__GetGlyph_b__0_Internal_Boolean_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphFormatter.__c__DisplayClass20_0>.NativeClassPtr, 100663583);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass20_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlyphFormatter.__c__DisplayClass20_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlyphFormatter.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20961, XrefRangeEnd = 20962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetGlyph_b__0(ActionElementMap m)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) m)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphFormatter.__c__DisplayClass20_0.NativeMethodInfoPtr__GetGlyph_b__0_Internal_Boolean_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe Controller controller
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphFormatter.__c__DisplayClass20_0.NativeFieldInfoPtr_controller));
        return num == System.IntPtr.Zero ? (Controller) null : Il2CppObjectPool.Get<Controller>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlyphFormatter.__c__DisplayClass20_0.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
