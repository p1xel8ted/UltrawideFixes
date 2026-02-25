// Decompiled with JetBrains decompiler
// Type: Replaced.Scripts.UI.UIDisplayControls
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Rewired;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Replaced.Scripts.UI;

public class UIDisplayControls(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_xbox;
  private static readonly System.IntPtr NativeFieldInfoPtr_ps;
  private static readonly System.IntPtr NativeFieldInfoPtr_nintendo;
  private static readonly System.IntPtr NativeFieldInfoPtr_xboxRoot;
  private static readonly System.IntPtr NativeFieldInfoPtr_psRoot;
  private static readonly System.IntPtr NativeFieldInfoPtr_nintendoRoot;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonActions;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnControllerChanged_Private_Void_Player_Controller_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessControls_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIDisplayControls()
  {
    Il2CppClassPointerStore<UIDisplayControls>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Replaced.Scripts.UI", nameof (UIDisplayControls));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDisplayControls>.NativeClassPtr);
    UIDisplayControls.NativeFieldInfoPtr_xbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDisplayControls>.NativeClassPtr, nameof (xbox));
    UIDisplayControls.NativeFieldInfoPtr_ps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDisplayControls>.NativeClassPtr, nameof (ps));
    UIDisplayControls.NativeFieldInfoPtr_nintendo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDisplayControls>.NativeClassPtr, nameof (nintendo));
    UIDisplayControls.NativeFieldInfoPtr_xboxRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDisplayControls>.NativeClassPtr, nameof (xboxRoot));
    UIDisplayControls.NativeFieldInfoPtr_psRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDisplayControls>.NativeClassPtr, nameof (psRoot));
    UIDisplayControls.NativeFieldInfoPtr_nintendoRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDisplayControls>.NativeClassPtr, nameof (nintendoRoot));
    UIDisplayControls.NativeFieldInfoPtr_buttonActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDisplayControls>.NativeClassPtr, nameof (buttonActions));
    UIDisplayControls.NativeMethodInfoPtr_OnControllerChanged_Private_Void_Player_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDisplayControls>.NativeClassPtr, 100670697);
    UIDisplayControls.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDisplayControls>.NativeClassPtr, 100670698);
    UIDisplayControls.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDisplayControls>.NativeClassPtr, 100670699);
    UIDisplayControls.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDisplayControls>.NativeClassPtr, 100670700);
    UIDisplayControls.NativeMethodInfoPtr_ProcessControls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDisplayControls>.NativeClassPtr, 100670701);
    UIDisplayControls.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDisplayControls>.NativeClassPtr, 100670702);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87509, XrefRangeEnd = 87510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnControllerChanged(Player player, Controller controller)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDisplayControls.NativeMethodInfoPtr_OnControllerChanged_Private_Void_Player_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87510, XrefRangeEnd = 87522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDisplayControls.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87522, XrefRangeEnd = 87533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDisplayControls.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDisplayControls.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 87697, RefRangeEnd = 87699, XrefRangeStart = 87533, XrefRangeEnd = 87697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessControls()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDisplayControls.NativeMethodInfoPtr_ProcessControls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87699, XrefRangeEnd = 87706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIDisplayControls()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDisplayControls>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDisplayControls.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe UIDisplayControls.ButtonToTextDict xbox
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.NativeFieldInfoPtr_xbox));
      return num == System.IntPtr.Zero ? (UIDisplayControls.ButtonToTextDict) null : Il2CppObjectPool.Get<UIDisplayControls.ButtonToTextDict>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.NativeFieldInfoPtr_xbox), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIDisplayControls.ButtonToTextDict ps
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.NativeFieldInfoPtr_ps));
      return num == System.IntPtr.Zero ? (UIDisplayControls.ButtonToTextDict) null : Il2CppObjectPool.Get<UIDisplayControls.ButtonToTextDict>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.NativeFieldInfoPtr_ps), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIDisplayControls.ButtonToTextDict nintendo
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.NativeFieldInfoPtr_nintendo));
      return num == System.IntPtr.Zero ? (UIDisplayControls.ButtonToTextDict) null : Il2CppObjectPool.Get<UIDisplayControls.ButtonToTextDict>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.NativeFieldInfoPtr_nintendo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image xboxRoot
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.NativeFieldInfoPtr_xboxRoot));
      return num == System.IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.NativeFieldInfoPtr_xboxRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image psRoot
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.NativeFieldInfoPtr_psRoot));
      return num == System.IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.NativeFieldInfoPtr_psRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image nintendoRoot
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.NativeFieldInfoPtr_nintendoRoot));
      return num == System.IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.NativeFieldInfoPtr_nintendoRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, HashSet<string>> buttonActions
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.NativeFieldInfoPtr_buttonActions));
      return num == System.IntPtr.Zero ? (Dictionary<string, HashSet<string>>) null : Il2CppObjectPool.Get<Dictionary<string, HashSet<string>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.NativeFieldInfoPtr_buttonActions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class ButtonToTextInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Text;
    private static readonly System.IntPtr NativeFieldInfoPtr_PromptOnLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_PresetText;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static ButtonToTextInfo()
    {
      Il2CppClassPointerStore<UIDisplayControls.ButtonToTextInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIDisplayControls>.NativeClassPtr, nameof (ButtonToTextInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDisplayControls.ButtonToTextInfo>.NativeClassPtr);
      UIDisplayControls.ButtonToTextInfo.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDisplayControls.ButtonToTextInfo>.NativeClassPtr, nameof (Text));
      UIDisplayControls.ButtonToTextInfo.NativeFieldInfoPtr_PromptOnLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDisplayControls.ButtonToTextInfo>.NativeClassPtr, nameof (PromptOnLeft));
      UIDisplayControls.ButtonToTextInfo.NativeFieldInfoPtr_PresetText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDisplayControls.ButtonToTextInfo>.NativeClassPtr, nameof (PresetText));
      UIDisplayControls.ButtonToTextInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDisplayControls.ButtonToTextInfo>.NativeClassPtr, 100670703);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ButtonToTextInfo()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDisplayControls.ButtonToTextInfo>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIDisplayControls.ButtonToTextInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe TMP_Text Text
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.ButtonToTextInfo.NativeFieldInfoPtr_Text));
        return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.ButtonToTextInfo.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool PromptOnLeft
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.ButtonToTextInfo.NativeFieldInfoPtr_PromptOnLeft));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.ButtonToTextInfo.NativeFieldInfoPtr_PromptOnLeft)) = value;
      }
    }

    public unsafe ArticyRef PresetText
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.ButtonToTextInfo.NativeFieldInfoPtr_PresetText));
        return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDisplayControls.ButtonToTextInfo.NativeFieldInfoPtr_PresetText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public class ButtonToTextDict(System.IntPtr pointer) : 
    UnitySerializedDictionary<string, UIDisplayControls.ButtonToTextInfo>(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static ButtonToTextDict()
    {
      Il2CppClassPointerStore<UIDisplayControls.ButtonToTextDict>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIDisplayControls>.NativeClassPtr, nameof (ButtonToTextDict));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDisplayControls.ButtonToTextDict>.NativeClassPtr);
      UIDisplayControls.ButtonToTextDict.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDisplayControls.ButtonToTextDict>.NativeClassPtr, 100670704);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87506, XrefRangeEnd = 87509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ButtonToTextDict()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDisplayControls.ButtonToTextDict>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIDisplayControls.ButtonToTextDict.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }
}
