// Decompiled with JetBrains decompiler
// Type: Replaced.Scripts.UI.UIControlsHelp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using SadCatStudios.PlayerInput;
using SadCatStudios.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Replaced.Scripts.UI;

public class UIControlsHelp(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_inputActionLabels;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentElements;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementBuilder;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetControlElements_Public_Void_Il2CppReferenceArray_1_ControlElement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIControlsHelp()
  {
    Il2CppClassPointerStore<UIControlsHelp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Replaced.Scripts.UI", nameof (UIControlsHelp));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIControlsHelp>.NativeClassPtr);
    UIControlsHelp.NativeFieldInfoPtr_inputActionLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlsHelp>.NativeClassPtr, nameof (inputActionLabels));
    UIControlsHelp.NativeFieldInfoPtr_currentElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlsHelp>.NativeClassPtr, nameof (currentElements));
    UIControlsHelp.NativeFieldInfoPtr_elementBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlsHelp>.NativeClassPtr, nameof (elementBuilder));
    UIControlsHelp.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlsHelp>.NativeClassPtr, 100670672);
    UIControlsHelp.NativeMethodInfoPtr_SetControlElements_Public_Void_Il2CppReferenceArray_1_ControlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlsHelp>.NativeClassPtr, 100670673);
    UIControlsHelp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlsHelp>.NativeClassPtr, 100670674);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87168, XrefRangeEnd = 87179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIControlsHelp.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87179, XrefRangeEnd = 87190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetControlElements(
    Il2CppReferenceArray<UIControlsHelp.ControlElement> elements)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) elements)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIControlsHelp.NativeMethodInfoPtr_SetControlElements_Public_Void_Il2CppReferenceArray_1_ControlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87190, XrefRangeEnd = 87195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIControlsHelp()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIControlsHelp>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIControlsHelp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<UIGlyphText> inputActionLabels
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlsHelp.NativeFieldInfoPtr_inputActionLabels));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<UIGlyphText>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<UIGlyphText>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIControlsHelp.NativeFieldInfoPtr_inputActionLabels), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<UIControlsHelp.ControlElement> currentElements
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlsHelp.NativeFieldInfoPtr_currentElements));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<UIControlsHelp.ControlElement>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<UIControlsHelp.ControlElement>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIControlsHelp.NativeFieldInfoPtr_currentElements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StringBuilder elementBuilder
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlsHelp.NativeFieldInfoPtr_elementBuilder));
      return num == System.IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIControlsHelp.NativeFieldInfoPtr_elementBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class ControlElement : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Action;

    static ControlElement()
    {
      Il2CppClassPointerStore<UIControlsHelp.ControlElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIControlsHelp>.NativeClassPtr, nameof (ControlElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIControlsHelp.ControlElement>.NativeClassPtr);
      UIControlsHelp.ControlElement.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlsHelp.ControlElement>.NativeClassPtr, nameof (Name));
      UIControlsHelp.ControlElement.NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlsHelp.ControlElement>.NativeClassPtr, nameof (Action));
    }

    public ControlElement(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ControlElement()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIControlsHelp.ControlElement>.NativeClassPtr))
    {
    }

    public unsafe string Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlsHelp.ControlElement.NativeFieldInfoPtr_Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIControlsHelp.ControlElement.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe InputAction Action
    {
      get
      {
        return *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlsHelp.ControlElement.NativeFieldInfoPtr_Action));
      }
      [param: In] set
      {
        *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlsHelp.ControlElement.NativeFieldInfoPtr_Action)) = value;
      }
    }
  }
}
