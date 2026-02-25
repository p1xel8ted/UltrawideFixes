// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.ControllerElementGlyph
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Rewired.Glyphs;

public class ControllerElementGlyph(IntPtr pointer) : ControllerElementGlyphBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__actionElementMap;
  private static readonly IntPtr NativeFieldInfoPtr__controllerElementIdentifier;
  private static readonly IntPtr NativeFieldInfoPtr__axisRange;
  private static readonly IntPtr NativeMethodInfoPtr_get_actionElementMap_Public_get_ActionElementMap_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_actionElementMap_Public_set_Void_ActionElementMap_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_controllerElementIdentifier_Public_get_ControllerElementIdentifier_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_controllerElementIdentifier_Public_set_Void_ControllerElementIdentifier_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static ControllerElementGlyph()
  {
    Il2CppClassPointerStore<ControllerElementGlyph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs", nameof (ControllerElementGlyph));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerElementGlyph>.NativeClassPtr);
    ControllerElementGlyph.NativeFieldInfoPtr__actionElementMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementGlyph>.NativeClassPtr, nameof (_actionElementMap));
    ControllerElementGlyph.NativeFieldInfoPtr__controllerElementIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementGlyph>.NativeClassPtr, nameof (_controllerElementIdentifier));
    ControllerElementGlyph.NativeFieldInfoPtr__axisRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementGlyph>.NativeClassPtr, nameof (_axisRange));
    ControllerElementGlyph.NativeMethodInfoPtr_get_actionElementMap_Public_get_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyph>.NativeClassPtr, 100668493);
    ControllerElementGlyph.NativeMethodInfoPtr_set_actionElementMap_Public_set_Void_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyph>.NativeClassPtr, 100668494);
    ControllerElementGlyph.NativeMethodInfoPtr_get_controllerElementIdentifier_Public_get_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyph>.NativeClassPtr, 100668495);
    ControllerElementGlyph.NativeMethodInfoPtr_set_controllerElementIdentifier_Public_set_Void_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyph>.NativeClassPtr, 100668496);
    ControllerElementGlyph.NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyph>.NativeClassPtr, 100668497);
    ControllerElementGlyph.NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyph>.NativeClassPtr, 100668498);
    ControllerElementGlyph.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyph>.NativeClassPtr, 100668499);
    ControllerElementGlyph.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyph>.NativeClassPtr, 100668500);
  }

  public unsafe ActionElementMap actionElementMap
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyph.NativeMethodInfoPtr_get_actionElementMap_Public_get_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ActionElementMap) null : Il2CppObjectPool.Get<ActionElementMap>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyph.NativeMethodInfoPtr_set_actionElementMap_Public_set_Void_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ControllerElementIdentifier controllerElementIdentifier
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyph.NativeMethodInfoPtr_get_controllerElementIdentifier_Public_get_ControllerElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ControllerElementIdentifier) null : Il2CppObjectPool.Get<ControllerElementIdentifier>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyph.NativeMethodInfoPtr_set_controllerElementIdentifier_Public_set_Void_ControllerElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AxisRange axisRange
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyph.NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AxisRange*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 68783, RefRangeEnd = 68785, XrefRangeStart = 68783, XrefRangeEnd = 68783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyph.NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68785, XrefRangeEnd = 68794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyph.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68794, XrefRangeEnd = 68795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ControllerElementGlyph()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerElementGlyph>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyph.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ActionElementMap _actionElementMap
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyph.NativeFieldInfoPtr__actionElementMap));
      return num == IntPtr.Zero ? (ActionElementMap) null : Il2CppObjectPool.Get<ActionElementMap>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyph.NativeFieldInfoPtr__actionElementMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerElementIdentifier _controllerElementIdentifier
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyph.NativeFieldInfoPtr__controllerElementIdentifier));
      return num == IntPtr.Zero ? (ControllerElementIdentifier) null : Il2CppObjectPool.Get<ControllerElementIdentifier>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyph.NativeFieldInfoPtr__controllerElementIdentifier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AxisRange _axisRange
  {
    get
    {
      return *(AxisRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyph.NativeFieldInfoPtr__axisRange));
    }
    [param: In] set
    {
      *(AxisRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyph.NativeFieldInfoPtr__axisRange)) = value;
    }
  }
}
