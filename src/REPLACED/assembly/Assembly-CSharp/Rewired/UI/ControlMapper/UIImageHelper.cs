// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.UIImageHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Rewired.UI.ControlMapper;

public class UIImageHelper(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_enabledState;
  private static readonly System.IntPtr NativeFieldInfoPtr_disabledState;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentState;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetEnabledState_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetEnabledStateColor_Public_Void_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetDisabledStateColor_Public_Void_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIImageHelper()
  {
    Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (UIImageHelper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr);
    UIImageHelper.NativeFieldInfoPtr_enabledState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr, nameof (enabledState));
    UIImageHelper.NativeFieldInfoPtr_disabledState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr, nameof (disabledState));
    UIImageHelper.NativeFieldInfoPtr_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr, nameof (currentState));
    UIImageHelper.NativeMethodInfoPtr_SetEnabledState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr, 100670066);
    UIImageHelper.NativeMethodInfoPtr_SetEnabledStateColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr, 100670067);
    UIImageHelper.NativeMethodInfoPtr_SetDisabledStateColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr, 100670068);
    UIImageHelper.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr, 100670069);
    UIImageHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr, 100670070);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80069, XrefRangeEnd = 80083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetEnabledState(bool newState)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &newState
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIImageHelper.NativeMethodInfoPtr_SetEnabledState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void SetEnabledStateColor(Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &color
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIImageHelper.NativeMethodInfoPtr_SetEnabledStateColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void SetDisabledStateColor(Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &color
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIImageHelper.NativeMethodInfoPtr_SetDisabledStateColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80083, XrefRangeEnd = 80095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Refresh()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIImageHelper.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIImageHelper()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIImageHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe UIImageHelper.State enabledState
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIImageHelper.NativeFieldInfoPtr_enabledState));
      return num == System.IntPtr.Zero ? (UIImageHelper.State) null : Il2CppObjectPool.Get<UIImageHelper.State>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIImageHelper.NativeFieldInfoPtr_enabledState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIImageHelper.State disabledState
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIImageHelper.NativeFieldInfoPtr_disabledState));
      return num == System.IntPtr.Zero ? (UIImageHelper.State) null : Il2CppObjectPool.Get<UIImageHelper.State>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIImageHelper.NativeFieldInfoPtr_disabledState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool currentState
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIImageHelper.NativeFieldInfoPtr_currentState));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIImageHelper.NativeFieldInfoPtr_currentState)) = value;
    }
  }

  [Serializable]
  public class State(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_color;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Image_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static State()
    {
      Il2CppClassPointerStore<UIImageHelper.State>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr, nameof (State));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIImageHelper.State>.NativeClassPtr);
      UIImageHelper.State.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImageHelper.State>.NativeClassPtr, nameof (color));
      UIImageHelper.State.NativeMethodInfoPtr_Set_Public_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageHelper.State>.NativeClassPtr, 100670071);
      UIImageHelper.State.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageHelper.State>.NativeClassPtr, 100670072);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80065, XrefRangeEnd = 80069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(Image image)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) image)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIImageHelper.State.NativeMethodInfoPtr_Set_Public_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe State()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIImageHelper.State>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIImageHelper.State.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Color color
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIImageHelper.State.NativeFieldInfoPtr_color));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIImageHelper.State.NativeFieldInfoPtr_color)) = value;
      }
    }
  }
}
