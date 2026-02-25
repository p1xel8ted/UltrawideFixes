// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.InputFieldInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Rewired.Glyphs.UnityUI;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Rewired.UI.ControlMapper;

public class InputFieldInfo(IntPtr pointer) : UIElementInfo(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__actionElementMapId;
  private static readonly IntPtr NativeFieldInfoPtr__axisRange;
  private static readonly IntPtr NativeFieldInfoPtr__glyphOrText_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr__actionId_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr__controllerType_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr__controllerId_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_get_glyphOrText_Public_get_UnityUIControllerElementGlyph_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_glyphOrText_Public_set_Void_UnityUIControllerElementGlyph_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_actionId_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_actionElementMapId_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_actionElementMapId_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_controllerType_Public_set_Void_ControllerType_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InputFieldInfo()
  {
    Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (InputFieldInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr);
    InputFieldInfo.NativeFieldInfoPtr__actionElementMapId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, nameof (_actionElementMapId));
    InputFieldInfo.NativeFieldInfoPtr__axisRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, nameof (_axisRange));
    InputFieldInfo.NativeFieldInfoPtr__glyphOrText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, "<glyphOrText>k__BackingField");
    InputFieldInfo.NativeFieldInfoPtr__actionId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, "<actionId>k__BackingField");
    InputFieldInfo.NativeFieldInfoPtr__controllerType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, "<controllerType>k__BackingField");
    InputFieldInfo.NativeFieldInfoPtr__controllerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, "<controllerId>k__BackingField");
    InputFieldInfo.NativeMethodInfoPtr_get_glyphOrText_Public_get_UnityUIControllerElementGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669775);
    InputFieldInfo.NativeMethodInfoPtr_set_glyphOrText_Public_set_Void_UnityUIControllerElementGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669776);
    InputFieldInfo.NativeMethodInfoPtr_get_actionId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669777);
    InputFieldInfo.NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669778);
    InputFieldInfo.NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669779);
    InputFieldInfo.NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669780);
    InputFieldInfo.NativeMethodInfoPtr_get_actionElementMapId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669781);
    InputFieldInfo.NativeMethodInfoPtr_set_actionElementMapId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669782);
    InputFieldInfo.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669783);
    InputFieldInfo.NativeMethodInfoPtr_set_controllerType_Public_set_Void_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669784);
    InputFieldInfo.NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669785);
    InputFieldInfo.NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669786);
    InputFieldInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669787);
  }

  public unsafe UnityUIControllerElementGlyph glyphOrText
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_get_glyphOrText_Public_get_UnityUIControllerElementGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (UnityUIControllerElementGlyph) null : Il2CppObjectPool.Get<UnityUIControllerElementGlyph>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_set_glyphOrText_Public_set_Void_UnityUIControllerElementGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int actionId
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 69970, RefRangeEnd = 69973, XrefRangeStart = 69970, XrefRangeEnd = 69973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_get_actionId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AxisRange*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 79050, RefRangeEnd = 79052, XrefRangeStart = 79046, XrefRangeEnd = 79050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int actionElementMapId
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_get_actionElementMapId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 79061, RefRangeEnd = 79063, XrefRangeStart = 79052, XrefRangeEnd = 79061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_set_actionElementMapId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ControllerType controllerType
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 74758, RefRangeEnd = 74763, XrefRangeStart = 74758, XrefRangeEnd = 74763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ControllerType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_set_controllerType_Public_set_Void_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int controllerId
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 68783, RefRangeEnd = 68785, XrefRangeStart = 68783, XrefRangeEnd = 68785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InputFieldInfo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int _actionElementMapId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__actionElementMapId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__actionElementMapId)) = value;
    }
  }

  public unsafe AxisRange _axisRange
  {
    get
    {
      return *(AxisRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__axisRange));
    }
    [param: In] set
    {
      *(AxisRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__axisRange)) = value;
    }
  }

  public unsafe UnityUIControllerElementGlyph _glyphOrText_k__BackingField
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__glyphOrText_k__BackingField));
      return num == IntPtr.Zero ? (UnityUIControllerElementGlyph) null : Il2CppObjectPool.Get<UnityUIControllerElementGlyph>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__glyphOrText_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _actionId_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__actionId_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__actionId_k__BackingField)) = value;
    }
  }

  public unsafe ControllerType _controllerType_k__BackingField
  {
    get
    {
      return *(ControllerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__controllerType_k__BackingField));
    }
    [param: In] set
    {
      *(ControllerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__controllerType_k__BackingField)) = value;
    }
  }

  public unsafe int _controllerId_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__controllerId_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__controllerId_k__BackingField)) = value;
    }
  }
}
