// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.CustomizationScene.ForceSliderToPowerOf2
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

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
namespace Tayx.Graphy.CustomizationScene;

public class ForceSliderToPowerOf2(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_slider;
  private static readonly IntPtr NativeFieldInfoPtr_m_powerOf2Values;
  private static readonly IntPtr NativeFieldInfoPtr_m_text;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Private_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ForceSliderToPowerOf2()
  {
    Il2CppClassPointerStore<ForceSliderToPowerOf2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.CustomizationScene", nameof (ForceSliderToPowerOf2));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceSliderToPowerOf2>.NativeClassPtr);
    ForceSliderToPowerOf2.NativeFieldInfoPtr_m_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceSliderToPowerOf2>.NativeClassPtr, nameof (m_slider));
    ForceSliderToPowerOf2.NativeFieldInfoPtr_m_powerOf2Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceSliderToPowerOf2>.NativeClassPtr, nameof (m_powerOf2Values));
    ForceSliderToPowerOf2.NativeFieldInfoPtr_m_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceSliderToPowerOf2>.NativeClassPtr, nameof (m_text));
    ForceSliderToPowerOf2.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSliderToPowerOf2>.NativeClassPtr, 100663727);
    ForceSliderToPowerOf2.NativeMethodInfoPtr_UpdateValue_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSliderToPowerOf2>.NativeClassPtr, 100663728 /*0x060001B0*/);
    ForceSliderToPowerOf2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSliderToPowerOf2>.NativeClassPtr, 100663729);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363957, XrefRangeEnd = 363967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ForceSliderToPowerOf2.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363967, XrefRangeEnd = 363973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateValue(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ForceSliderToPowerOf2.NativeMethodInfoPtr_UpdateValue_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363973, XrefRangeEnd = 363980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ForceSliderToPowerOf2()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForceSliderToPowerOf2>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ForceSliderToPowerOf2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Slider m_slider
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForceSliderToPowerOf2.NativeFieldInfoPtr_m_slider));
      return num == IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForceSliderToPowerOf2.NativeFieldInfoPtr_m_slider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<int> m_powerOf2Values
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForceSliderToPowerOf2.NativeFieldInfoPtr_m_powerOf2Values));
      return num == IntPtr.Zero ? (Il2CppStructArray<int>) null : Il2CppObjectPool.Get<Il2CppStructArray<int>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForceSliderToPowerOf2.NativeFieldInfoPtr_m_powerOf2Values), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text m_text
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForceSliderToPowerOf2.NativeFieldInfoPtr_m_text));
      return num == IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForceSliderToPowerOf2.NativeFieldInfoPtr_m_text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
