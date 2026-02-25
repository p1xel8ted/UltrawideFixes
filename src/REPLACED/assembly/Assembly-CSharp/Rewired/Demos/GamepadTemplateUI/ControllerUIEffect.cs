// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.GamepadTemplateUI.ControllerUIEffect
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
namespace Rewired.Demos.GamepadTemplateUI;

public class ControllerUIEffect(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__highlightColor;
  private static readonly IntPtr NativeFieldInfoPtr__image;
  private static readonly IntPtr NativeFieldInfoPtr__color;
  private static readonly IntPtr NativeFieldInfoPtr__origColor;
  private static readonly IntPtr NativeFieldInfoPtr__isActive;
  private static readonly IntPtr NativeFieldInfoPtr__highlightAmount;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_RedrawImage_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ControllerUIEffect()
  {
    Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos.GamepadTemplateUI", nameof (ControllerUIEffect));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr);
    ControllerUIEffect.NativeFieldInfoPtr__highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, nameof (_highlightColor));
    ControllerUIEffect.NativeFieldInfoPtr__image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, nameof (_image));
    ControllerUIEffect.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, nameof (_color));
    ControllerUIEffect.NativeFieldInfoPtr__origColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, nameof (_origColor));
    ControllerUIEffect.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, nameof (_isActive));
    ControllerUIEffect.NativeFieldInfoPtr__highlightAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, nameof (_highlightAmount));
    ControllerUIEffect.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, 100670470);
    ControllerUIEffect.NativeMethodInfoPtr_Activate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, 100670471);
    ControllerUIEffect.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, 100670472);
    ControllerUIEffect.NativeMethodInfoPtr_RedrawImage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, 100670473);
    ControllerUIEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, 100670474);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84935, XrefRangeEnd = 84938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControllerUIEffect.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 84941, RefRangeEnd = 84943, XrefRangeStart = 84938, XrefRangeEnd = 84941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Activate(float amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &amount
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControllerUIEffect.NativeMethodInfoPtr_Activate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 84944, RefRangeEnd = 84946, XrefRangeStart = 84943, XrefRangeEnd = 84944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Deactivate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControllerUIEffect.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84946, XrefRangeEnd = 84948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RedrawImage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControllerUIEffect.NativeMethodInfoPtr_RedrawImage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84948, XrefRangeEnd = 84949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ControllerUIEffect()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControllerUIEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Color _highlightColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__highlightColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__highlightColor)) = value;
    }
  }

  public unsafe Image _image
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__image));
      return num == IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color _color
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__color));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__color)) = value;
    }
  }

  public unsafe Color _origColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__origColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__origColor)) = value;
    }
  }

  public unsafe bool _isActive
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__isActive));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__isActive)) = value;
    }
  }

  public unsafe float _highlightAmount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__highlightAmount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__highlightAmount)) = value;
    }
  }
}
