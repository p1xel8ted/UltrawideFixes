// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.GamepadTemplateUI.ControllerUIElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Rewired.Demos.GamepadTemplateUI;

public class ControllerUIElement(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__highlightColor;
  private static readonly IntPtr NativeFieldInfoPtr__positiveUIEffect;
  private static readonly IntPtr NativeFieldInfoPtr__negativeUIEffect;
  private static readonly IntPtr NativeFieldInfoPtr__label;
  private static readonly IntPtr NativeFieldInfoPtr__positiveLabel;
  private static readonly IntPtr NativeFieldInfoPtr__negativeLabel;
  private static readonly IntPtr NativeFieldInfoPtr__childElements;
  private static readonly IntPtr NativeFieldInfoPtr__image;
  private static readonly IntPtr NativeFieldInfoPtr__color;
  private static readonly IntPtr NativeFieldInfoPtr__origColor;
  private static readonly IntPtr NativeFieldInfoPtr__isActive;
  private static readonly IntPtr NativeFieldInfoPtr__highlightAmount;
  private static readonly IntPtr NativeMethodInfoPtr_get_hasEffects_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetLabel_Public_Void_String_AxisRange_0;
  private static readonly IntPtr NativeMethodInfoPtr_ClearLabels_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_RedrawImage_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ControllerUIElement()
  {
    Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos.GamepadTemplateUI", nameof (ControllerUIElement));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr);
    ControllerUIElement.NativeFieldInfoPtr__highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, nameof (_highlightColor));
    ControllerUIElement.NativeFieldInfoPtr__positiveUIEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, nameof (_positiveUIEffect));
    ControllerUIElement.NativeFieldInfoPtr__negativeUIEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, nameof (_negativeUIEffect));
    ControllerUIElement.NativeFieldInfoPtr__label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, nameof (_label));
    ControllerUIElement.NativeFieldInfoPtr__positiveLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, nameof (_positiveLabel));
    ControllerUIElement.NativeFieldInfoPtr__negativeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, nameof (_negativeLabel));
    ControllerUIElement.NativeFieldInfoPtr__childElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, nameof (_childElements));
    ControllerUIElement.NativeFieldInfoPtr__image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, nameof (_image));
    ControllerUIElement.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, nameof (_color));
    ControllerUIElement.NativeFieldInfoPtr__origColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, nameof (_origColor));
    ControllerUIElement.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, nameof (_isActive));
    ControllerUIElement.NativeFieldInfoPtr__highlightAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, nameof (_highlightAmount));
    ControllerUIElement.NativeMethodInfoPtr_get_hasEffects_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, 100670475);
    ControllerUIElement.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, 100670476);
    ControllerUIElement.NativeMethodInfoPtr_Activate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, 100670477);
    ControllerUIElement.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, 100670478);
    ControllerUIElement.NativeMethodInfoPtr_SetLabel_Public_Void_String_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, 100670479);
    ControllerUIElement.NativeMethodInfoPtr_ClearLabels_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, 100670480);
    ControllerUIElement.NativeMethodInfoPtr_RedrawImage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, 100670481);
    ControllerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, 100670482);
  }

  public unsafe bool hasEffects
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84949, XrefRangeEnd = 84953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControllerUIElement.NativeMethodInfoPtr_get_hasEffects_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84953, XrefRangeEnd = 84958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControllerUIElement.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 84982, RefRangeEnd = 84984, XrefRangeStart = 84958, XrefRangeEnd = 84982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Activate(float amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &amount
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControllerUIElement.NativeMethodInfoPtr_Activate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 84998, RefRangeEnd = 85000, XrefRangeStart = 84984, XrefRangeEnd = 84998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Deactivate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControllerUIElement.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 85012, RefRangeEnd = 85015, XrefRangeStart = 85000, XrefRangeEnd = 85012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetLabel(string text, AxisRange labelType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &labelType;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControllerUIElement.NativeMethodInfoPtr_SetLabel_Public_Void_String_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 85033, RefRangeEnd = 85036, XrefRangeStart = 85015, XrefRangeEnd = 85033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearLabels()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControllerUIElement.NativeMethodInfoPtr_ClearLabels_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void RedrawImage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControllerUIElement.NativeMethodInfoPtr_RedrawImage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85036, XrefRangeEnd = 85040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ControllerUIElement()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControllerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Color _highlightColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__highlightColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__highlightColor)) = value;
    }
  }

  public unsafe ControllerUIEffect _positiveUIEffect
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__positiveUIEffect));
      return num == IntPtr.Zero ? (ControllerUIEffect) null : Il2CppObjectPool.Get<ControllerUIEffect>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__positiveUIEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIEffect _negativeUIEffect
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__negativeUIEffect));
      return num == IntPtr.Zero ? (ControllerUIEffect) null : Il2CppObjectPool.Get<ControllerUIEffect>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__negativeUIEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text _label
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__label));
      return num == IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__label), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text _positiveLabel
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__positiveLabel));
      return num == IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__positiveLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text _negativeLabel
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__negativeLabel));
      return num == IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__negativeLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ControllerUIElement> _childElements
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__childElements));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<ControllerUIElement>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ControllerUIElement>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__childElements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image _image
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__image));
      return num == IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color _color
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__color));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__color)) = value;
    }
  }

  public unsafe Color _origColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__origColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__origColor)) = value;
    }
  }

  public unsafe bool _isActive
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__isActive));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__isActive)) = value;
    }
  }

  public unsafe float _highlightAmount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__highlightAmount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__highlightAmount)) = value;
    }
  }
}
